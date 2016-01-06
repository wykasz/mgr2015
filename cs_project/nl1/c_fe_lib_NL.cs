using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace nianio
{
    class c_fe_lib_NL
    {
        private static ImmOv NL_get_ov(String var, Imm val) {
            return c_rt_lib_NL.NL_ov_mk_arg(new ImmString(var), val);
	    }

        private static void NL_print(String str)
        {
            NL_print(new ImmString(str));
	    }

        public static void NL_print(Imm arg)
        {
            c_rt_lib_NL.NL_print(arg);
	    }

        public static ImmOv NL_file_to_string(Imm filename)
        {
            return NL_read_file(((ImmString)filename).getStringValue());
	    }

        private static ImmOv NL_read_file(String filename)
        {
            string readContents;
            try
            {
                using (StreamReader streamReader = new StreamReader(filename))
                {
                    readContents = streamReader.ReadToEnd();
                }
                return NL_get_ov("ok", new ImmString(readContents));
            }
            catch
            {
                return NL_get_ov("err", new ImmDouble(0));
            }
	    }

        public static ImmOv NL_string_to_file(Imm filename, Imm content)
        {
		    return write_file(((ImmString) filename).getStringValue(),
                    ((ImmString)content).getStringValue());
	    }

        static byte[] GetBytes(string str)
        {
            byte[] bytes = new byte[str.Length * sizeof(char)];
            System.Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
            return bytes;
        }

        static string GetString(byte[] bytes)
        {
            char[] chars = new char[bytes.Length / sizeof(char)];
            System.Buffer.BlockCopy(bytes, 0, chars, 0, bytes.Length);
            return new string(chars);
        }

	    private static ImmOv write_file(String filename, String content) {
		    //FileStream fileStream = new FileStream(filename, FileMode.Create);
            File.WriteAllText(filename, content, Encoding.UTF8);
            //byte[] contentBytes = GetBytes(content);
            //fileStream.Write(contentBytes, 0, contentBytes.Length);

            return NL_get_ov("ok", new ImmString(""));
	    }

        public static Imm NL_get_file_size(Imm filename)
        {
            FileInfo f = new FileInfo(((ImmString)filename).getStringValue());
		    long s = f.Length;
		    if (s == -1)
                return NL_get_ov("err", new ImmString("File doesn't exists"));
            return NL_get_ov("ok", new ImmDouble(s));
	    }

	    private static long get_file_size(String filename) {
		    FileInfo f = new FileInfo(filename);
		    return f.Length;
	    }

        public static Imm NL_get_modif_time(Imm filename)
        {
            FileInfo f = new FileInfo(((ImmString)filename).getStringValue());
            double s = f.LastWriteTime.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
            return NL_get_ov("ok", new ImmDouble(s));
	    }

        public static Imm NL_get_module_files_rec(Imm directory)
        {
		    ImmRef file = new ImmRef(new ImmArray(new Imm[0]));
            get_files_rec(((ImmString)directory).getStringValue(), file,
				    true);
		    return file.getValue();
	    }

        public static Imm NL_get_module_files(Imm directory)
        {
		    ImmRef file = new ImmRef(new ImmArray(new Imm[0]));
            Imm ret = get_files_rec(((ImmString)directory).getStringValue(),
                    file, true);
		    if (ret == null)
                return NL_get_ov("ok", file.getValue());
		    file.setValue(null);
		    return ret;
	    }

	    private static ImmOv get_files_rec(String path, ImmRef files, bool deep) {
            foreach (string f in Directory.GetFiles(path))
            {
                Imm imm = new ImmString(f);
                c_std_lib_NL.NL_array_push(files, imm);
            }

            if (deep)
            {
                string[] dirs = Directory.GetDirectories(path);
                foreach (string d in dirs)
                {
                    string npath = d;
                    get_files_rec(npath, files, deep);
                }
            }

		    return null;
	    }

        public static void NL_mk_path(Imm path)
        {
            Directory.CreateDirectory(((ImmString)path).getStringValue());
	    }

        public static Imm NL_get_time()
        {
            DateTime now = DateTime.Now;
            TimeSpan unix = now.Subtract(new DateTime(1970, 1, 1));
            double s = unix.TotalSeconds;
            double us = unix.TotalMilliseconds % 1000 * 1000;

		    Imm[] imm = new Imm[] { new ImmDouble(s), new ImmDouble(us) };
		    return new ImmArray(imm);
	    }

        public static void NL_sleep(Imm imm)
        {
		    Thread.Sleep(((int)((ImmDouble) imm).getValue()) * 1000);
	    }

        public static void NL_exec_cmd(Imm imm)
        {
            String cmd = ((ImmString)imm).getStringValue();

            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = cmd;
            process.StartInfo = startInfo;
            process.Start();

            process.WaitForExit();
	    }
    }
}
