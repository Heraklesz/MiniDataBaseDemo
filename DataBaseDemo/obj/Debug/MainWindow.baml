   M S B A M L   `   `   `  ����G  CDataBaseDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:DataBaseDemoDataBaseDemo  5   	       DataBaseDemo.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:DataBaseDemo     5   	   -   5          � Title$  
MainWindow��5   	   $��618.266��6   $��299.399��6-    � 	Resources 5	         carViewSource��%   &	        �� 5
   
   6   5      .��5      �  � DataContext# [  6   $��0,0,104,-0.2q�68    � ColumnDefinitions 5   
   �� 5      $
��167* �6   �� 5      $	��81* �6   �� 5      $��8* �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ carDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��0,10,-100.2,309q�6{      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $��3��6�   ��6c   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        colourColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Colour��5   V   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 SizeToHeader 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Colour+6f     5      -   5        driverNameColumn��$	 Driver Name��5   ^   $
 SizeToHeader 6s    6?   �� *
DriverName+6s     5      -   5        registeredNumberColumn��$	 Registered Number��5   j   $
 SizeToHeader 6�    6E   �� *RegisteredNumber+6�     5      -   5        
typeColumn��$
	 Type��5   R   $
 SizeToHeader 6`    69   �� *Type+6`   5      �� 5   
   -   5         ��Name$ button��5      $��RedCars��6!   $
��Left=�63   $��	0,285,0,0q�6N   $	��Top=�6a   $��75��6y   6�   �� 5   
   -   5        $ button1��5      $��Janos'sCars��6"   $
��Left=�68   $��	0,455,0,0q�6S   $	��Top=�6f   $��75��6~   6�   �� 5   
   -	   5         ��Name$ listBox��5      $
��Left=�6#   $	��100��6>   $��0,309,-0.2,0q�6K   $	��Top=�6a   $	��189��6y   $��3��6�   �� 5   
   -
   5        $ listBox1��5      $
��Left=�6$   $	��100��6?   $��0,479,-0.2,0q�6L   $	��Top=�6b   $	��189��6z   $��3��6�   5      5       