   M S B A M L   `   `   `  ����J  FWpfToDoListDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:WpfDemoMvvm.ViewsWpfDemoMvvm.Views  5   	   "    WpfDemoMvvm.Views.MainWindow   5   	   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:WpfDemoMvvm.Views     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��200��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   �� $��0��6   $��My ToDo List��6!   67   �� 5   
   $��1��6   .��5      �� -   5         ��Name$ lstToDoControl��5      ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5   "   $
��Auto �63   �� 5   "   $��* �63   �� 5   "   $
��Auto �63   .+�5      �� $��0��6'    d� 	IsChecked 67   �� *	IsChecked+�� 5      $��1��6(   ��68   �� *	Content+�� 5      -   5        $��2��5   %   ��6N   �� .��6k   Remove6s   5      5      5       5!      � 5"   
   $��2��6    5#      �� 5$      $��* �6#   �� 5%      $
��Auto �6#   .+�5'      �� -   5         ��Name$ txtToDoItem��5'      $��0��6+   �� 5(      -   5         ��Name$ 
btnAddToDo��5(      $��1��6)   .��6O   
Add ToDo6Y   5)      5+      5,      