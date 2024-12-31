using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceQuest.Services
{
    public class UserProgressService
    {
        public void SaveProgress(int xp, int level, int streak)
        {
            Preferences.Set("XP", xp);
            Preferences.Set("Level", level);
            Preferences.Set("Streak", streak);
        }

        public (int XP, int Level, int Streak) GetProgress()
        {
            int xp = Preferences.Get("XP", 0);  // Default to 0 if not set
            int level = Preferences.Get("Level", 1);  // Default to level 1
            int streak = Preferences.Get("Streak", 0);  // Default to streak 0

            return (xp, level, streak);
        }

        public void ResetStreak()
        {
            Preferences.Set("Streak", 0);  // Reset streak to 0
        }
    }
}
