﻿// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("Build", "CA1051:Nie deklaruj widocznych pól wystąpień", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.ChooseChange.anuluj")]
[assembly: SuppressMessage("Build", "CA1823:Nieużywane pole „br”.", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.br")]
[assembly: SuppressMessage("Build", "CA1051:Nie deklaruj widocznych pól wystąpień", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.dc")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.eA")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.eB")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.eC")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.endPointY")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.fontFamily")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.fontsize")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.FS")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.oper")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.zA")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.zB")]
[assembly: SuppressMessage("Build", "CA2211:Pola niebędące stałymi nie powinny być widoczne", Justification = "<Oczekujące>", Scope = "member", Target = "~F:Uniterm.MyDrawing.zOp")]
[assembly: SuppressMessage("Build", "CA2200:Ponowne zgłoszenie przechwyconego wyjątku powoduje zmianę informacji o stosie.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.Connect")]
[assembly: SuppressMessage("Build", "CA2100:Sprawdź, czy ciąg zapytania przekazany do elementu „SqlDataAdapter.SqlDataAdapter(string selectCommandText, SqlConnection selectConnection)” w elemencie „CreateAdapter” akceptuje dowolne dane wejściowe użytkownika.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.CreateAdapter(System.String)~System.Data.SqlClient.SqlDataAdapter")]
[assembly: SuppressMessage("Build", "CA2000:Wywołaj metodę System.IDisposable.Dispose dla obiektu utworzonego przez „new DataTable()”, zanim wszystkie odwołania do niego będą poza zakresem.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.CreateDataRow(System.String)~System.Data.DataRow")]
[assembly: SuppressMessage("Build", "CA1303:Metoda DataRow DataBase.CreateDataRow(string query) przekazuje ciąg literału jako parametr „message” wywołania elementu Exception.Exception(string message). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Nie można połączyć się z bazą daych”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.CreateDataRow(System.String)~System.Data.DataRow")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „CreateDataRow”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.CreateDataRow(System.String)~System.Data.DataRow")]
[assembly: SuppressMessage("Build", "CA1303:Metoda DataTable DataBase.CreateDataTable(string query) przekazuje ciąg literału jako parametr „message” wywołania elementu Exception.Exception(string message). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Nie można połączyć się z bazą daych”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.CreateDataTable(System.String)~System.Data.DataTable")]
[assembly: SuppressMessage("Build", "CA2000:Wywołaj metodę System.IDisposable.Dispose dla obiektu utworzonego przez „CreateAdapter(query)”, zanim wszystkie odwołania do niego będą poza zakresem.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.CreateDataTable(System.String)~System.Data.DataTable")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „Disconnect”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.Disconnect")]
[assembly: SuppressMessage("Build", "CA1303:Metoda void DataBase.RunQuery(string query) przekazuje ciąg literału jako parametr „message” wywołania elementu Exception.Exception(string message). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Nie można połączyć się z bazą daych”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.RunQuery(System.String)")]
[assembly: SuppressMessage("Build", "CA2100:Sprawdź, czy ciąg zapytania przekazany do elementu „SqlCommand.SqlCommand(string cmdText, SqlConnection connection)” w elemencie „RunQuery” akceptuje dowolne dane wejściowe użytkownika.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.RunQuery(System.String)")]
[assembly: SuppressMessage("Build", "CA2000:Wywołaj metodę System.IDisposable.Dispose dla obiektu utworzonego przez „new SqlCommand(query, this.ConnectionString)”, zanim wszystkie odwołania do niego będą poza zakresem.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.DataBase.RunQuery(System.String)")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „ClearAll”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyCanvas.ClearAll")]
[assembly: SuppressMessage("Build", "CA1820:Sprawdzenie pod kątem ciągu pustego wykonuj za pomocą właściwości „string.Length” lub metody „string.IsNullOrEmpty” zamiast sprawdzania pod kątem równości.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.DrawElim(System.Windows.Point)")]
[assembly: SuppressMessage("Build", "CA1305:Zachowanie elementu „string.ToString()” może być różne w zależności od bieżących ustawień regionalnych użytkownika. Zastąp to wywołanie w metodzie „MyDrawing.DrawElim(Point)” wywołaniem metody „string.ToString(IFormatProvider)”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.DrawElim(System.Windows.Point)")]
[assembly: SuppressMessage("Build", "CA1305:Zachowanie elementu „string.ToString()” może być różne w zależności od bieżących ustawień regionalnych użytkownika. Zastąp to wywołanie w metodzie „MyDrawing.DrawSwitched(Point)” wywołaniem metody „string.ToString(IFormatProvider)”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.DrawSwitched(System.Windows.Point)")]
[assembly: SuppressMessage("Build", "CA1305:Zachowanie elementu „string.ToString()” może być różne w zależności od bieżących ustawień regionalnych użytkownika. Zastąp to wywołanie w metodzie „MyDrawing.drawZrow(Point)” wywołaniem metody „string.ToString(IFormatProvider)”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.drawZrow(System.Windows.Point)")]
[assembly: SuppressMessage("Build", "CA1820:Sprawdzenie pod kątem ciągu pustego wykonuj za pomocą właściwości „string.Length” lub metody „string.IsNullOrEmpty” zamiast sprawdzania pod kątem równości.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.drawZrow(System.Windows.Point)")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski GetBezierPoints nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.GetBezierPoints(System.Windows.Point,System.Windows.Point,System.Windows.Point,System.Windows.Point)~System.Collections.Generic.IEnumerable{System.Windows.Point}")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski GetFormattedText nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.MyDrawing.GetFormattedText(System.String)~System.Windows.Media.FormattedText")]
[assembly: SuppressMessage("Build", "CA1303:Metoda void Window1.btnEl_Click(object sender, RoutedEventArgs e) przekazuje ciąg literału jako parametr „caption” wywołania elementu MessageBoxResult MessageBox.Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Błąd”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.btnEl_Click(System.Object,System.Windows.RoutedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1303:Metoda void Window1.btnZrow_Click(object sender, RoutedEventArgs e) przekazuje ciąg literału jako parametr „caption” wywołania elementu MessageBoxResult MessageBox.Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Błąd”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.btnZrow_Click(System.Object,System.Windows.RoutedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1303:Metoda bool Window1.CheckSave() przekazuje ciąg literału jako parametr „caption” wywołania elementu MessageBoxResult MessageBox.Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Zapis”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.CheckSave~System.Boolean")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „ehCBFontsChanged”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.ehCBFontsChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „ehcbfSizeChanged”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.ehcbfSizeChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „ehlbUNitermsSelectionChanged”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.ehlbUNitermsSelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1305:Zachowanie elementu „string.Format(string, params object[])” może być różne w zależności od bieżących ustawień regionalnych użytkownika. Zastąp to wywołanie w metodzie „Window1.ehlbUNitermsSelectionChanged(object, SelectionChangedEventArgs)” wywołaniem metody „string.Format(IFormatProvider, string, params object[])”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.ehlbUNitermsSelectionChanged(System.Object,System.Windows.Controls.SelectionChangedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1031:Zmodyfikuj element „MenuItem_Click_1”, aby przechwytywać dokładniej określony typ wyjątku, lub ponownie zgłoś wyjątek.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.MenuItem_Click_1(System.Object,System.Windows.RoutedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1303:Metoda void Window1.MenuItem_Click_1(object sender, RoutedEventArgs e) przekazuje ciąg literału jako parametr „caption” wywołania elementu MessageBoxResult MessageBox.Show(string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon). Zamiast tego pobierz następujące ciągi z tabeli zasobów: „Wystąpił błąd”.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.MenuItem_Click_1(System.Object,System.Windows.RoutedEventArgs)")]
[assembly: SuppressMessage("Build", "CA2000:Wywołaj metodę System.IDisposable.Dispose dla obiektu utworzonego przez „db.CreateDataTable(\"select name from uniterms;\")”, zanim wszystkie odwołania do niego będą poza zakresem.", Justification = "<Oczekujące>", Scope = "member", Target = "~M:Uniterm.Window1.Window_Loaded(System.Object,System.Windows.RoutedEventArgs)")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski Window1 nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.AddElem.Window1")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski Window1 nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.AddZrownoleglenie.Window1")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski Window1 nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.App.Window1")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski Window1 nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.ChooseChange.Window1")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski App nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.DataBase.App")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski MyCanvas nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.Window1.MyCanvas")]
[assembly: SuppressMessage("Build", "CA1822:Element członkowski MyDrawing nie uzyskuje dostępu do danych wystąpień i może zostać oznaczony jako statyczny (Shared w języku VisualBasic).", Justification = "<Oczekujące>", Scope = "member", Target = "~P:Uniterm.Window1.MyDrawing")]
[assembly: SuppressMessage("Build", "CA1001:Typ „DataBase” zawiera pola możliwe do likwidacji („conString”), ale sam nie jest możliwy do likwidacji", Justification = "<Oczekujące>", Scope = "type", Target = "~T:Uniterm.DataBase")]
