Module Module1

    Sub Main()
		Dim n As Integer = Nothing ' цена билета в рублях
		Dim x As Integer ' количество жетонов номиналом 4 рубля
		Dim y As Integer ' количество жетонов номиналом 7 рублей
		' Ввод цены билета
		Console.Write("Цена билета в рублях: ") ' Вывод подсказки
		Integer.TryParse(Console.ReadLine(), n) ' Ввод натурального числа
		x = 0 ' количество жетонов по 4
		y = 0 ' количество жетонов по 7
		' Перебираем количество жетонов по 7 от максимума до 0
		For y = n \ 7 To 0 Step -1
			Dim remainder As Integer = n - 7 * y ' Сумму разменяли на жетоны по 7
			If remainder Mod 4 = 0 Then ' Остаток разменяли на жетоны по 4
				x = remainder \ 4 ' Если удалось разменять всю сумму, конец цикла
				'Вывод найденного решения на экран
				Console.WriteLine($"Введённую цену {n} можно разменять на жетоны:")
				Console.WriteLine($"Количество жетонов по 4 рубля: {x}")
				Console.WriteLine($"Количество жетонов по 7 рублей: {y}")
				Exit For ' Завершить цикл
			End If
		Next y
		' Решений для указанной суммы нет
		If (x <= 0) AndAlso (y <= 0) Then
			Console.WriteLine($"Введённую цену {n} нельзя разменять на жетоны")
		End If
		Console.Read() ' Задержка вывода на экран до нажатия клавиши "Ввод"
	End Sub

End Module
