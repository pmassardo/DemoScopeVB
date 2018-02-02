
Option Strict On
''' <summary>
''' Author:         Alfred Massardo
''' Project Name:   DemoScope
''' Date:           02-Feb-2018
''' Description:    Demonstrate class scope of variableFormLevelScope 
'''                 by maintaining the variable's state/value,
'''                 as long as, the form is open.
''' </summary>
Public Class frmDemoScope

    ' declare a variable that will live for
    ' as long as the form/class will live
    ' this will also be available to all
    ' procedure (subs/functons) with in
    ' the class
    Private variableFormLevelScope As Double = 0 ' form/class level scope

    ''' <summary>
    ''' btnEnter_Click - fires when the enter button is clicked and calls
    '''                 the Add function to add two numbers and return 
    '''                 the sum and assign it to the form/class level
    '''                 variable
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        Dim numberOne As Double = 2 ' procedure level scope
        Dim numberTwo As Double = 5 ' procedure level scope

        variableFormLevelScope += Add(numberOne, numberTwo) ' call the Add function to add the 2 numbers

        ' concatenate the string in the textbox to it self and then 
        ' concatenate the current value of the form/class level variable
        ' concatenate the Visual Basic Cariage return Line feed
        tbOutput.Text += variableFormLevelScope.ToString & vbCrLf

    End Sub

    ''' <summary>
    ''' Add - Adds two numbers
    '''     *** Function is a self contained area of code that contains one or more lines of code that can be called by another procedure and returns a value to the calling code. 
    ''' </summary>
    ''' <param name="numberOne">Double</param>
    ''' <param name="numberTwo">Double</param>
    ''' <returns>Double - the sum of the two arguments passed to the Method/Function</returns>
    Private Function Add(numberOne As Double, numberTwo As Double) As Double

        ' declare a return value variable
        Dim returnValue As Double ' procedure level scope

        ' add number one parameter to number two parameter
        ' and assign it to return value
        returnValue = numberOne + numberTwo

        ' return the return value variable
        Return returnValue

    End Function


    ''' <summary>
    ''' The Click event of the reset button Is fired when the
    ''' user clicks the reset button when they wish to clear the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        ' reset the output text box
        tbOutput.ResetText()

        ' reset the form/class level 
        ' scoped variable(s)
        variableFormLevelScope = 0

    End Sub

    ''' <summary>
    ''' btnExit_Click - when click will call the form method to close the form
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Exit Application
        Me.Close()

        ' Closing the form will remove the variableFormLevelScope from memory

    End Sub

End Class
