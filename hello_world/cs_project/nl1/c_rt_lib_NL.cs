using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nianio
{
    class c_rt_lib_NL
    {
        private static ImmOv trueVariant = NL_ov_mk_none(new ImmString("TRUE"));
        private static ImmOv falseVariant = NL_ov_mk_none(new ImmString("FALSE"));

        private static bool NL_isOV(Imm variant)
        {
		    bool r = variant is ImmOv;
            return r;
	    }

        public static void NL_die()
        {
		    throw new Exception("NL_DIE");
	    }

        public static Imm NL_clone(Imm obj)
        {
		    return obj.clone();
	    }

        public static ImmDouble NL_array_len(Imm arr)
        {
		    return new ImmDouble(((ImmArray) arr).getCount());
	    }

        public static Imm NL_get_ref_arr(Imm arr, Imm ind)
        {
            return ((ImmArray)arr).getArrayValue()[
                        (int)((ImmDouble) ind).getDoubleValue()
                   ];
	    }

        public static void NL_set_ref_arr(ref Imm arr, Imm ind, Imm value)
        { // arr ref
            c_rt_lib_NL.NL_arg_val(value);
            ImmArray immArr = (ImmArray)(arr);
            immArr.getArrayValue()[
                (int)((ImmDouble)ind).getDoubleValue()
            ].decRef();
            immArr.getArrayValue()[
                (int)((ImmDouble)ind).getDoubleValue()
            ] = value;            
	    }

        public static Imm NL_get_ref_hash(Imm hash, Imm key)
        {
            return NL_hash_get_value(hash, key);
	    }

        public static void NL_set_ref_hash(ref Imm hash, Imm key, Imm value)
        { // ref hash
            NL_hash_set_value(ref hash, key, value);
	    }

        public static Imm NL_init_iter(Imm hash)
        {
		    Dictionary<String, Imm> baseMap = ((ImmHash) hash).getHashValue();
		    Imm[] arr = new Imm[baseMap.Count];
            int i = 0;
            foreach (String s in baseMap.Keys){
                arr[i] = new ImmString(s);
                ++i;
            }
		   
		    Dictionary<String, Imm> map = new Dictionary<String, Imm>();
		    map.Add("pos", new ImmDouble(0));
		    map.Add("keys", new ImmArray(arr));
		    return new ImmHash(map);
	    }

        public static ImmOv NL_is_end_hash(Imm iter)
        {
            return NL_native_to_nl(get_iter_position(iter) >= get_iter_keys(iter).Count);
	    }
	
	    private static int get_iter_position(Imm iter) {
            Imm pos = ((ImmHash)iter).get("pos");
		    return (int)((ImmDouble)pos).getDoubleValue();
	    }
	
	    private static List<Imm> get_iter_keys(Imm iter) {
		    return ((ImmArray)((ImmHash)iter).get("keys")).getArrayValue();
	    }

        public static ImmString NL_get_key_iter(Imm iter)
        {
		    return (ImmString)get_iter_keys(iter)[get_iter_position(iter)];
	    }

        public static Imm NL_next_iter(Imm iter)
        {
		    ImmHash map = (ImmHash)iter.clone();
		    int position = get_iter_position(iter) + 1;
            map.set("pos", new ImmDouble(position));
		    return map;
	    }

        public static Imm NL_hash_get_value(Imm hash, Imm key)
        {
		    return ((ImmHash) hash).getHashValue()[key.toString()];
	    }

        public static void NL_hash_set_value(ref Imm hash, Imm key, Imm value)
        {
            ImmHash immHash = (ImmHash)hash;
            immHash.set(key.toString(), value);
	    }

        public static Imm NL_ov_as(Imm variant, Imm name)
        {
            if (!NL_isOV(variant)
				    || !((ImmOv) variant).getName().Equals(((ImmString) name).getStringValue())
				    || variant.getValue() == null)
                NL_die();
		    return ((ImmOv) variant).getOvValue();
	    }

        public static ImmOv NL_ov_is(Imm variant, Imm name)
        {
            if (!NL_isOV(variant))
                NL_die();
            return NL_native_to_nl(((ImmOv)variant).getName().Equals(((ImmString)name).getStringValue()));
	    }

        public static ImmOv NL_ov_has_value(Imm variant)
        {
            if (!NL_isOV(variant))
                NL_die();
            return NL_native_to_nl(((ImmOv)variant).getValue() != null);
	    }

        public static Imm NL_ov_get_value(Imm variant)
        {
            if (!NL_isOV(variant) || variant.getValue() == null)
                NL_die();
		    return ((ImmOv) variant).getOvValue();
	    }

        public static ImmString NL_ov_get_element(Imm variant)
        {
            if (!NL_isOV(variant))
                NL_die();
		    return new ImmString(((ImmOv) variant).getName());
	    }

        public static ImmOv NL_ov_arg_new(Imm name, Imm arg)
        {
            return NL_ov_mk_arg((ImmString)name, arg);
	    }

        public static ImmOv NL_ov_none_new(Imm name)
        {
            return NL_ov_mk_none(((ImmString)name));
	    }

        public static ImmOv NL_ov_mk_arg(ImmString name, Imm value)
        {
		    return new ImmOv(name.getStringValue(), value);
	    }

        public static ImmOv NL_ov_mk_none(ImmString name)
        {
            return new ImmOv(name.getStringValue());
	    }

        public static bool NL_check_true_native(Imm value)
        {
		    if (value == trueVariant) return true;
		    if (value == falseVariant) return false;
		    return ((ImmOv) value).getName().Equals("TRUE");
	    }

        public static ImmOv NL_get_false()
        {
		    return falseVariant;
	    }

        public static ImmOv NL_get_true()
        {
		    return trueVariant;
	    }

        public static ImmOv NL_native_to_nl(bool value)
        {
            return value ? NL_get_true() : NL_get_false();
	    }

        public static void NL_print(Imm imm)
        {
            System.Console.WriteLine(imm.toString());
	    }

        public static void NL_move(ref Imm left, Imm right)
        {
            if(left != null) left.decRef();
            left = right;
        }

        public static void NL_copy(ref Imm left, Imm right)
        {
            if (left != null) left.decRef();
            left = right;
            left.incRef();
        }

        public static void NL_clear(ref Imm left)
        {
            if (left != null) left.decRef();
        }

        public static void NL_arg_val(Imm right)
        {
            right.incRef();
        }
    }
}
