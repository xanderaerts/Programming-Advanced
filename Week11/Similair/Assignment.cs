using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_11 {
	public class Assignment
	{
		public bool CheckSimilair(string i1, string i2)
		{
			if (i1.Length != i2.Length) throw new Exception();

			Dictionary<char, char> map = new Dictionary<char, char>();

			for (int i = 0; i < i1.Length;i++) {

				char one = i1[i];
				char two = i2[i];

				if (map.ContainsKey(one))
				{
					if (map[one] != two)
					{
						return false;
					}
				}
				else {
					if (map.ContainsValue(two)) return false;
				}

				map[one] = two;
			}

		

			return true;
		}
	}
}
