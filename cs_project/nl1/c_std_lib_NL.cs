using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace nianio
{
    class c_std_lib_NL
    {
        
	    private static Imm global_profile = null;

        public static ImmHash NL_get_profile_global()
        {
		    if (global_profile == null) {
			    global_profile = new ImmHash(new Dictionary<String, Imm>());
		    }
		    return (ImmHash) global_profile;
	    }

        public static void NL_set_profile_global(Imm imm)
        {
		    global_profile = imm;
	    }

        public static ImmString NL_fast_substr(Imm sarr, Imm start, Imm length)
        {
            List<Imm> arr = ((ImmArray)sarr).getArrayValue();
            if (((ImmArray)sarr).getCount() != 1)
                c_rt_lib_NL.NL_die();
            return NL_string_sub(arr[0], start, length);
	    }

        public static ImmDouble NL_string_get_char_code(Imm str, Imm pos)
        {
            string s = ((ImmString)str).getStringValue();
            char c = s[(int)((ImmDouble)pos).getDoubleValue()];
            return new ImmDouble((double)c);
        }

        public static ImmArray NL_array_sub(Imm array, Imm begin, Imm length)
        {
		    int from = (int) ((ImmDouble) begin).getDoubleValue();
            int to = from + (int)((ImmDouble)length).getDoubleValue();
            int len = (int)((ImmDouble)length).getDoubleValue();

            List<Imm> arr = new List<Imm>(len);
            List<Imm> org = ((ImmArray)array).getArrayValue();
            for (int i = from; i < to; i++)
                arr.Add(org[i]);
		    return new ImmArray(arr);
	    }

        public static ImmArray NL_array_sort(Imm arr, Imm func)
        {
            List<Imm> immArr = ((ImmArray)arr).getArrayValue();
		    NLcomparator a = new NLcomparator(func);
            immArr.Sort(a);
		    return new ImmArray(immArr);
	    }

        public static void NL_array_push(ImmRef arr, Imm el)
        {
            List<Imm> l = ((ImmArray)arr.getValue()).getArrayValue();
            l.Add(el);
		    arr.setValue(new ImmArray(l));
	    }

        public static ImmDouble NL_array_len(Imm arr)
        {
            return c_rt_lib_NL.NL_array_len(arr);
	    }

        public static void NL_array_pop(ImmRef arr)
        {
            List<Imm> l = ((ImmArray)arr.getValue()).getArrayValue();
            l.RemoveAt(l.Count-1);
		    arr.setValue(new ImmArray(l));
	    }

        public static Imm NL_hash_get_value(Imm hash, Imm key)
        {
            return c_rt_lib_NL.NL_hash_get_value(hash, key);
	    }

        public static ImmOv NL_hash_has_key(Imm hash, Imm key)
        {
            return c_rt_lib_NL.NL_native_to_nl(((ImmHash)hash).getHashValue()
				    .ContainsKey(key.toString()));
	    }

        public static void NL_hash_set_value(ImmRef hash, Imm key, Imm value)
        { // ref hash
            c_rt_lib_NL.NL_hash_set_value(hash, key, value);
	    }

        public static void NL_hash_delete(ImmRef hash, Imm key)
        { // ref hash
		    hash.setValue(new ImmHash(new Dictionary<String, Imm>(((ImmHash) hash
				    .getValue()).getHashValue())));
		    ((ImmHash) hash.getValue()).getHashValue().Remove(key.toString());
	    }

        public static ImmDouble NL_hash_size(Imm hash)
        {
		    return new ImmDouble(((ImmHash) hash).getHashValue().Count);
	    }

        public static ImmString NL_string_chr(Imm code)
        {
            int n = (int)((ImmDouble)code).getDoubleValue();
            char c = Convert.ToChar(n);
		    return new ImmString(c.ToString());
	    }

        public static ImmDouble NL_string_ord(Imm str)
        {
            String s = str.toString();
            char c = s.ToCharArray()[0];
            double d = c;
		    return new ImmDouble(d);
	    }

        public static ImmDouble NL_string_length(Imm str)
        {
		    return new ImmDouble(str.toString().Length);
	    }

        public static ImmDouble NL_string_index(Imm str, Imm substr, Imm start)
        {
            String s = ((ImmString) str).getStringValue();
            String f = ((ImmString) substr).getStringValue();
            int p = (int)((ImmDouble)start).getDoubleValue();
            int v = s.IndexOf(f, p);
		    return new ImmDouble(v);
	    }

        public static ImmString NL_string_sub(Imm str, Imm start, Imm length)
        {
            String s = ((ImmString)str).getStringValue();
            int b = (int)((ImmDouble)start).getDoubleValue();
            int e = (int)((ImmDouble)length).getDoubleValue();
            return new ImmString(s.Substring(b, e));
	    }

        public static ImmString NL_string_replace(Imm str, Imm old, Imm new_part)
        {
            String s = ((ImmString)str).getStringValue();
            String oldStr = old.toString();
            String newStr = old.toString();
            return new ImmString(s.Replace(oldStr, newStr));
	    }

        public static ImmDouble NL_string_compare(Imm a, Imm b)
        {
            String s1 = ((ImmString)a).getStringValue();
            String s2 = ((ImmString)b).getStringValue();
            return new ImmDouble(s1.CompareTo(s2));
	    }

        public static ImmOv NL_is_array(Imm imm)
        {
            return c_rt_lib_NL.NL_native_to_nl(imm is ImmArray);
	    }

        public static ImmOv NL_is_hash(Imm imm)
        {
            return c_rt_lib_NL.NL_native_to_nl(imm is ImmHash);
	    }

        public static ImmOv NL_is_sim(Imm imm)
        {
            return c_rt_lib_NL.NL_native_to_nl(imm is ImmString || imm is ImmDouble);
	    }

        public static ImmOv NL_is_variant(Imm imm)
        {
            return c_rt_lib_NL.NL_native_to_nl(imm is ImmOv);
	    }

        public static void NL_print(Imm imm)
        {
            c_rt_lib_NL.NL_print(imm);
	    }

        public static Imm NL_exec(Imm func, ImmRef arr)
        {
            ImmArray array = (ImmArray)arr.getValue();
            Object[] obj_array = new Object[array.getCount()];

            int i = 0;
            foreach(Imm imm in array.getArrayValue()){
                obj_array[i] = imm;
                ++i;
            }
                   

            MethodInfo m = getMethodFromImm(func);
            Object result = m.Invoke(null, obj_array);
            Imm imm_result = (Imm)result;

		    /*Imm[] immArr = ((ImmArray) arr.clone()).getArrayValue();
		    Object[] newArr = new ImmRef[immArr.Length];
		    for (int i = 0; i < newArr.Length; i++) {
			    newArr[i] = new ImmRef(immArr[i]);
		    }
		    Object result = null;
            MethodInfo m = getMethodFromImm(func);
		    if (m != null)
			    result = m.Invoke(null, newArr);
		    for (int i = 0; i < newArr.Length; i++) {
			    immArr[i] = ((ImmRef) newArr[i]).getValue();
		    }
		    arr.setValue(new ImmArray(immArr));
            return result;*/
            return imm_result;
	    }

	    public static MethodInfo getMethodFromImm(Imm imm) {
		    Dictionary<String, Imm> map = ((ImmHash) (c_rt_lib_NL.NL_ov_as(imm,
				    new ImmString("ref")))).getHashValue();

            String module = ((ImmString) map["module"]).getStringValue();
            String name = ((ImmString)map["name"]).getStringValue();

            Type t2 = Type.GetType("nianio.array_NL");
            Type t = Type.GetType("nianio."+module);
    	    MethodInfo method  = t.GetMethod("NL_"+name, BindingFlags.Static | BindingFlags.Public);
            return method;
	    }
    }

    class NLcomparator : IComparer<Imm>
    {

        private MethodInfo m;

        public NLcomparator(Imm func)
        {
            m = c_std_lib_NL.getMethodFromImm(func);
        }

        public int Compare(Imm o1, Imm o2)
        {
            try
            {
                Imm res = (Imm) m.Invoke(null, new Object[] { o1, o2 });
                return c_rt_lib_NL.NL_check_true_native((ImmOv)res) ? -1 : 1;
            }
            catch (Exception e)
            {
                c_rt_lib_NL.NL_print(new ImmString(e.ToString()));
            }
            return 0;
        }
    }
}
