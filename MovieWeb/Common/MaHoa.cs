using System.Security.Cryptography;
using System.Text;

namespace MovieWeb.Common
{
	public class MaHoa
	{
		public static string GetMd5Hash(string input)
		{
			using (MD5 md5Hash = MD5.Create())
			{
				// Chuyển đổi input thành một mảng byte và tính toán giá trị mã hóa MD5
				byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

				// Tạo một StringBuilder để lưu trữ các byte đã mã hóa thành một chuỗi hex
				StringBuilder sBuilder = new StringBuilder();

				// Lặp qua từng byte của dữ liệu đã mã hóa và đổi thành chuỗi hex
				for (int i = 0; i < data.Length; i++)
				{
					sBuilder.Append(data[i].ToString("x2"));
				}

				// Trả về chuỗi hex đã được mã hóa
				return sBuilder.ToString();
			}
		}

		public static string GetMd5Hash16(string input)
		{
			string hash = GetMd5Hash(input);
			if (hash.Length >= 16)
			{
				return hash.Substring(0, 16);
			}
			return hash;
		}
	}






}
