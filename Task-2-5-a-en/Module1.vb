Module Module1

	Sub Main()
		Dim n As Integer = Nothing ' ticket price in rubles
		Dim x As Integer ' number of 4-ruble tokens
		Dim y As Integer ' number of 7-ruble tokens
		' Input ticket price
		Console.Write("Ticket price in rubles: ") ' Display prompt
		Integer.TryParse(Console.ReadLine(), n) ' Input a natural number
		x = 0 ' number of 4-ruble tokens
		y = 0 ' number of 7-ruble tokens
		' Iterate through the number of 7-ruble tokens from maximum down to 0
		For y = n \ 7 To 0 Step -1
			Dim remainder As Integer = n - 7 * y ' Amount after using 7-ruble tokens
			If remainder Mod 4 = 0 Then ' Check if remainder can be covered by 4-ruble tokens
				x = remainder \ 4 ' If the full amount is covered, end the loop
				' Display the found solution
				Console.WriteLine($"The entered price {n} can be exchanged for tokens:")
				Console.WriteLine($"Number of 4-ruble tokens: {x}")
				Console.WriteLine($"Number of 7-ruble tokens: {y}")
				Exit For ' exit loop
			End If
		Next y
		' No solution for the specified amount
		If (x <= 0) AndAlso (y <= 0) Then
			Console.WriteLine($"The entered price {n} cannot be exchanged for tokens")
		End If
		Console.Read() ' Pause output until the "Enter" key is pressed
	End Sub

End Module
