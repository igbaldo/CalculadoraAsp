namespace OperationLibrary
{
    public class Operation
    {
        public int Suma(string num1, string num2)
        {
            int res;

            try
            {
                int val1;
                int val2;

                int.TryParse(num1, out val1);
                int.TryParse(num2, out val2);

                res = val1 + val2;
            }
            catch
            {
                throw;
            }

            return res;
        }
    }
}