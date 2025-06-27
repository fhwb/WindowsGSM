using System.Diagnostics;

namespace WindowsGSM.Functions.CPU
{
    static class Priority
    {
        public static int GetPriorityInteger(string priority)
        {
            if (int.TryParse(priority, out int result))
            {
                return result;
            }

            return 2;
        }

        public static string GetPriorityByInteger(int priority)
        {
            switch (priority)
            {
                case 0: return "最低";
                case 1: return "稍低";
                default:
                case 2: return "正常";
                case 3: return "稍高";
                case 4: return "较高";
                case 5: return "实时";
            }
        }

        public static Process SetProcessWithPriority(Process p, int priority)
        {
            switch (priority)
            {
                case 0: p.PriorityClass = ProcessPriorityClass.Idle; break;
                case 1: p.PriorityClass = ProcessPriorityClass.BelowNormal; break;
                default:
                case 2: p.PriorityClass = ProcessPriorityClass.Normal; break;
                case 3: p.PriorityClass = ProcessPriorityClass.AboveNormal; break;
                case 4: p.PriorityClass = ProcessPriorityClass.High; break;
                case 5: p.PriorityClass = ProcessPriorityClass.RealTime; break;
            }

            return p;
        }
    }
}
