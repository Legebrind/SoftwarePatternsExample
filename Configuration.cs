
public class Configuration 
{
    private static Configuration instance;
    private Dictionary<string, string> settings = new Dictionary<string, string>();

    private Configuration() 
    { 
        settings["resolution"] = "1920x1080"; 
        settings["volume"] = "80"; 
    }

    public static Configuration Instance 
    { 
        get 
        { 
            if (instance == null) 
            { 
                instance = new Configuration(); 
            } 
            return instance; 
        } 
    }

    public string GetSetting(string key) 
    { 
        if (settings.ContainsKey(key)) 
        { 
            return settings[key]; 
        } 
        else 
        { 
            return null; 
        } 
    }

    public void SetSetting(string key, string value) 
    { 
        settings[key] = value; 
    }
}
