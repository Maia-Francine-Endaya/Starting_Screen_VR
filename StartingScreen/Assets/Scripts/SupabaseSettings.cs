using UnityEngine;

namespace com.example
{
  [CreateAssetMenu(fileName = "Supabase", menuName = "Supabase/Supabase Settings", order = 1)]
  public class SupabaseSettings : ScriptableObject
  {
    public string SupabaseURL = "https://183c69f5009.enov8tive.app/";

    public string SupabaseAnonKey = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyAgCiAgICAicm9sZSI6ICJhbm9uIiwKICAgICJpc3MiOiAic3VwYWJhc2UtZGVtbyIsCiAgICAiaWF0IjogMTY0MTc2OTIwMCwKICAgICJleHAiOiAxNzk5NTM1NjAwCn0.dc_X5iR_VP_qT0zsiyj_I_OZ2T9FtRU2BBNWN8Bu4GE!";
  }
}
