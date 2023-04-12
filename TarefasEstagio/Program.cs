bool IsPalindrome(int x)
{
	string xToString = x.ToString();
	List<string> ListOfxReversed = new List<string>();
	for (int i = xToString.Length - 1; i>=0; i--)
	{
		ListOfxReversed.Add(xToString[i].ToString());  	
	}

    Console.WriteLine(string.Join("", ListOfxReversed));
	Console.WriteLine(xToString);

	if (ListOfxReversed.ToString() == xToString)
	{
		return true;
	} 
	else
	{
		return false;
	}
}

IsPalindrome(123);