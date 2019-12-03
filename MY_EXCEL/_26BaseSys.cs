namespace MY_EXCEL
{
    public class _26BaseSys
    {
        public string To26Sys(int i)
        {
            int k = 0;
            int[] arr = new int[100];
            while (i > 25)
            {
                arr[k] = i / 26 - 1;
                k++;
                i = i % 26;
            }

            arr[k] = i;
            string result = "";
            for (int j = 0; j <= k; j++)
                result += ((char)('A' + arr[j])).ToString();

            return result;
        }

        public int From26Sys(string columnHeader)
        {
            char[] charArr = columnHeader.ToCharArray();
            int l = charArr.Length;
            int res = 0;
            for (int i = l - 2; i >= 0; i--)
                res += (((int)charArr[i] - (int)'A') + 1) * System.Convert.ToInt32(System.Math.Pow(26, l - i - 1));
            res += ((int)charArr[l - 1] - (int)'A');

            return res;
        }
    }
}
