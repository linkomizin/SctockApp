using ClassLibrary.Model;

namespace ClassLibrary
{
    public class HandlerCanAddPallet : ICanAddpallet
    {
        public bool CanAddPallet(DimensionsBase pallete, DimensionsBase box)
        {
            double[] arr = new double[] { box.Length, box.Width, box.Height };
            bool canADd = false;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    canADd = CanAdd(pallete.Length, pallete.Width, arr[i], arr[j]);
                    if (canADd == true)
                    {
                        return canADd;
                    }
                }
            }
            return canADd;
        }

        private bool CanAdd(double A, double B, double C, double D)
        {
            if ((A > C && B > D) || (A > D && B > C))
            {
                return true;
            }

            return false;
        }
    }
}
