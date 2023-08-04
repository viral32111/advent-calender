Imports System.Text.RegularExpressions
Imports System.Threading

Public Class adventForm
	Dim audioThread As Thread
	Dim jokes As New Dictionary(Of String, String()) From {
		{"What does Santa suffer from if he gets stuck in a chimney?", {"Claustrophobia!"}},
		{"Why does Santa have three gardens?", {"So he can 'ho ho ho'!"}},
		{"Why did Santa go to the doctor?", {"Because of his bad elf!"}},
		{"Why did Santa's helper see the doctor?", {"Because he had a low elf esteem!"}},
		{"What kind of motorbike does Santa ride?", {"A Holly Davidson!"}},
		{"What do you call a cat in the desert?", {"Sandy Claws!"}},
		{"Who delivers presents to cats?", {"Santa Paws!"}},
		{"What do you call a dog who works for Santa?", {"Santa Paws!"}},
		{"What do you call Father Christmas in the beach?", {"Sandy Clause!"}},
		{"What do you get if you cross Santa with a detective?", {"Santa Clues!"}},
		{"What did the sea Say to Santa?", {"Nothing! It just waved!"}},
		{"What does Santa do with fat elves?", {"He sends them to an Elf Farm!"}},
		{"What do you get if you cross Santa with a duck?", {"A Christmas Quacker!"}},
		{"Who delivers presents to baby sharks at Christmas?", {"Santa Jaws"}},
		{"What says Oh Oh Oh?", {"Santa walking backwards!"}},
		{"What goes Ho Ho Whoosh, Ho Ho Whoosh?", {"Santa going through a revolving door!"}},
		{"What is Santa's favorite place to deliver presents?", {"Idaho-ho-ho!"}},
		{"Why does Santa go down the chimney on Christmas Eve?", {"Because it 'soots' him!"}},
		{"Who is Santa's favorite singer?", {"Elf-is Presley!"}},
		{"What do you call Santa's little helpers?", {"Subordinate clauses!"}},
		{"What do Santa's little helpers learn at school?", {"The elf-abet!"}},
		{"What did Santa say to the smoker?", {"Please don't smoke, it's bad for my elf!"}},
		{"Where does Santa go when he's sick?", {"To the elf center!"}},
		{"What do you call a bankrupt Santa?", {"Saint Nickel-less!"}}
	}


	Private Function getInts(ByVal value As String) As Integer
		Dim returnVal As String = String.Empty
		Dim collection As MatchCollection = Regex.Matches(value, "\d+")

		For Each m As Match In collection
			returnVal += m.ToString()
		Next

		Return Convert.ToInt32(returnVal)
	End Function

	Private Sub adventButtonPress(sender As Object, e As EventArgs) Handles day9Button.Click, day8Button.Click, day7Button.Click, day6Button.Click, day5Button.Click, day4Button.Click, day3Button.Click, day2Button.Click, day1Button.Click, day25Button.Click, day24Button.Click, day23Button.Click, day22Button.Click, day21Button.Click, day20Button.Click, day19Button.Click, day18Button.Click, day17Button.Click, day16Button.Click, day15Button.Click, day14Button.Click, day13Button.Click, day12Button.Click, day11Button.Click, day10Button.Click
		Dim button As Button = sender
		Dim currentDay As Int32 = DateTime.Now.Day
		Dim buttonDay As Int32 = getInts(button.Name)

		If (buttonDay <= currentDay) Then
			MessageBox.Show(jokes.Keys(buttonDay) + Environment.NewLine + Environment.NewLine + jokes.Values(buttonDay)(0))
		Else
			MessageBox.Show("It's not the " + buttonDay.ToString() + " yet.")
		End If
	End Sub

	Private Sub adventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		audioThread = New Thread(AddressOf playAudio)
		audioThread.Start()
	End Sub

	Private Sub playAudio()
		My.Computer.Audio.Play(My.Resources.last_christmas, AudioPlayMode.WaitToComplete)
	End Sub

	Private Sub adventForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
		'My.Computer.Audio.Stop()
		'audioThread.Abort()
	End Sub
End Class
