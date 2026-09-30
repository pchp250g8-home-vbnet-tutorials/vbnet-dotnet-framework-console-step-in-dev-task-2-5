Module Module1

    Sub Main()
		Dim n As Integer = Nothing ' ticket price in rubles
		Dim x As Integer ' number of 4-ruble tokens
		Dim y As Integer ' number of 7-ruble tokens
		Dim found As Boolean = False ' flag indicating if a solution has been found
		' Input ticket price
		Console.Write("Ticket price in rubles: ") ' Display prompt
		Integer.TryParse(Console.ReadLine(), n) ' Input a natural number
		y = n \ 7 ' Start with the maximum number of 7-ruble tokens
		' Iterate through the number of 7-ruble tokens from maximum down to 0,
		' until a solution is found or we run out of 7-ruble tokens
		Do While (y >= 0) AndAlso (Not found)
			Dim remainder As Integer = n - 7 * y ' Amount remaining after using 7-ruble tokens
			If remainder Mod 4 = 0 Then ' Check if the remainder can be covered by 4-ruble tokens
				x = remainder \ 4 ' If the full amount is covered, end the loop
				' Display the found solution
				Console.WriteLine($"The entered price of {n} can be broken down into tokens:")
				Console.WriteLine($"Number of 4-ruble tokens: {x}")
				Console.WriteLine($"Number of 7-ruble tokens: {y}")
				' Set the flag variable to true,
				' since a solution has been found
				found = True
			End If
			y -= 1 ' Decrease the number of 7-ruble tokens
		Loop
		' No solution exists for the specified amount
		If Not found Then
			Console.WriteLine($"The entered price of {n} rubles cannot be broken down into tokens")
		End If
		Console.Read() ' Pause output until the "Enter" key is pressed
	End Sub

End Module
