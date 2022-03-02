using Salaros.Configuration;

namespace InstallerV2
{
    public class ConfigManager : ConfigParser
    {
        public ConfigManager(ConfigParserSettings settings = null) : base(settings)
        {

        }
        public ConfigManager(string configFile, ConfigParserSettings settings = null) : base(configFile, settings)
        {

        }

        public bool exists_key(string sec, string key)
        {
            try
            {
                var _ = this[sec][key];
                if (_ == null || _ == "")
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool exists_section(string sec)
        {
            try
            {
                var _ = this[sec];
                if (_ == null || !this.sections.ContainsKey(sec))
                {
                    return false;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public (bool, string) validate_section(string sec, string[] keys)
        {
            foreach (string key in keys)
            {
                if (!exists_key(sec, key))
                {
                    return (false, key);
                }
            }
            return (true, null);
        }

        public string try_get(string sec, string key, string else_ret = null)
        {
            if (!exists_key(sec, key)) return this[sec][key];
            else return else_ret;
        }
    }
}
