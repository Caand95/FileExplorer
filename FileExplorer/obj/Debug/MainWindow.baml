   M S B A M L   `   `   `  ����G  CFileExplorer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FileExplorerFileExplorer  5   	   =#clr-namespace:FileExplorer.GUI.ViewFileExplorer.GUI.View  5   	   A%clr-namespace:FileExplorer.GUI.ThemesFileExplorer.GUI.Themes  5   	   G(clr-namespace:FileExplorer.GUI.ViewModelFileExplorer.GUI.ViewModel  5	   	   I)clr-namespace:FileExplorer.GUI.ConvertersFileExplorer.GUI.Converters  5
   	       FileExplorer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FileExplorer     5   	   1V#clr-namespace:FileExplorer.GUI.View     5   	   4Tc%clr-namespace:FileExplorer.GUI.Themes     5   	   7VM(clr-namespace:FileExplorer.GUI.ViewModel     5	   	   @
Converters)clr-namespace:FileExplorer.GUI.Converters     5
   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5      5  /FileExplorer.GUI.Converters.ColorToHexConverter   ColorToHexConverter��%   &	          5   
   6)   5      .��5      � -   5         �Name$ 
LayoutRoot��5       � RowDefinitions 5   
   �� 5      $
��0.5* �6   �� 5      $
��9.5* �6    � ColumnDefinitions 5   
   �� 5      $
��0.3* �6   �� 5      $
��0.7* �6   �� 5      $
��0.4* �6   .+�5   
   &    FileExplorer.GUI.View.AddressBar  $��0��6   $��2��6$   �� 5   
   $��0��6   $��2��6   $��1��6.   $��ThemeToggler��6�   ��6B   �� *ThemeChangerCommand+��6j   �� *CurrentTheme+6�   $   FileExplorer.GUI.View.Treeview  5   
   $��1��6   $��0��6"   $��1��62   &    FileExplorer.GUI.View.FolderView  5   
   $��1��6   $��1��6$   $��2��64   5       5!      