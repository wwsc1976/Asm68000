using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using System.Xml;

namespace Asm68000
{
public class ApplicationSettings
{
 public string AppName { get; private set; }
 private string Section = "Settings";

public ApplicationSettings(string appName)
{
 AppName = appName; 
}

public void SaveSetting(string name, string value)
{
 Microsoft.VisualBasic.Interaction.SaveSetting(AppName, Section, name, value);
}

public void SaveSetting(string name, int value)
{
 SaveSetting(name, value.ToString()); 
}

public void SaveSetting(string name, float value)
{
 SaveSetting(name, value.ToString()); 
}

public void SaveSetting(string name, double value)
{
 SaveSetting(name, value.ToString()); 
}

public void SaveSetting(string name, bool value)
{
 string sVal;

 if (value == true)
   sVal = "1";
 else
   sVal = "0";

 SaveSetting(name, sVal); 
}

public void SaveSetting(string name, DateTime dt)
{
 SaveSetting(name + "_Year", dt.Year.ToString()); 
 SaveSetting(name + "_Month", dt.Month.ToString()); 
 SaveSetting(name + "_Day", dt.Day.ToString()); 
 SaveSetting(name + "_Hour", dt.Hour.ToString()); 
 SaveSetting(name + "_Minute", dt.Minute.ToString()); 
 SaveSetting(name + "_Second", dt.Second.ToString()); 
}


public string GetString(string name, string defaultValue = "")
{
 return Microsoft.VisualBasic.Interaction.GetSetting(AppName, Section, name, defaultValue);
}

public int GetInt(string name, int defaultValue = 0)
{
 string val = GetString(name, defaultValue.ToString());
 int ret;

 if (int.TryParse(val, out ret) == true)
   return ret;
 else
   return defaultValue;
}

public float GetFloat(string name, float defaultValue)
{
 string val = GetString(name, defaultValue.ToString());
 float ret;

 if (float.TryParse(val, out ret) == true)
   return ret;
 else
   return defaultValue;
}

public double GetDouble(string name, double defaultValue)
{
 string val = GetString(name, defaultValue.ToString());
 double ret;

 if (double.TryParse(val, out ret) == true)
   return ret;
 else
   return defaultValue;
}

public bool GetBool(string name, bool defaultValue = false)
{
 string val = GetString(name, defaultValue.ToString());
 int ret;

 if (int.TryParse(val, out ret) == true)
   return ret == 1;
 else
   return defaultValue;
}

public DateTime GetDate(string name, DateTime def)
{
 int y, mon, day, h, min, sec;
 DateTime dt;

 y = GetInt(name + "_Year", def.Year); 
 mon = GetInt(name + "_Month", def.Month); 
 day = GetInt(name + "_Day", def.Day); 
 h = GetInt(name + "_Hour", def.Hour); 
 min = GetInt(name + "_Minute", def.Minute); 
 sec = GetInt(name + "_Second", def.Second); 
 dt = new DateTime(h, mon, day, h, min, sec);

 return dt;
}

};

}
