   M S B A M L   `   `   `  ����N  JTicketingSystem.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:TicketingSystem.WPF.DataTicketingSystem.WPF.Data  5   	   ?$clr-namespace:TicketingSystem.WPF.VMTicketingSystem.WPF.VM  5   	   ?$clr-namespace:TicketingSystem.WPF.UITicketingSystem.WPF.UI  5	   	   $    TicketingSystem.WPF.MainWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namesapce:TicketinySystem.WPF     5   	   7data&clr-namespace:TicketingSystem.WPF.Data     5   	   3vm$clr-namespace:TicketingSystem.WPF.VM     5   	   3ui$clr-namespace:TicketingSystem.WPF.UI     5	   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��676��6)    � 	Resources 5      5   /TicketingSystem.WPF.UI.CardTypeToBrushConverter   CardTypeToBrushConverter*  $TicketingSystem.WPF.VM.MainViewModel  VM  listTemplate �� DataType+   %TicketingSystem.WPF.Data.CashierModel �� Path �� 	Converter �� ContentStringFormat��%8  &	        &	      &	 &     7     5   
   6&     5   
   6   �� 5   
   "  6,   .R�5      ]� ��6   �� $ CardType�8   .+�5      �� $	��Top=�66   $��Center=�6K   ��6   �� $
 Name�6K   �� 5      $	��Top=�69   $
��Left=�6N   ��6   �� $ Address�6N   �� 5      $��Bottom=�6:   $��Center=�6R   ��6   �� $ CardType�6R   �� 5      $
��Left=�6;   ��6   �� $ 	Insurance�6;   �� 5      $��Right=�68   $ {0} HUF��6O   ��6   �� $ Salary�6O   �� 5      5      5      5      .��5      �  � DataContext# [ 6   .+�5   
   �� $
��Left=�6   $	��421��62   $��	16,38,0,0q�6?   $	��Top=�6R   $	��302��6j   .��5      �� #��[ 6   $��Stretch=�5      ��5   C   �� $ GroupOfCashier� �� SelectedItem 6o   �� $ CashierSelected�5      5       �� 5!   
   $	��Add��61   $
��Left=�6?   $��46��6Z   $��
380,50,0,0q�6f   $	��Top=�6z   $	��104��6�   ��6   �� $ AddCmd�6�   �� 5"   
   $��Modify��61   $
��Left=�6B   $��42��6]   $��380,119,0,0q�6i   $	��Top=�6~   $	��104��6�   ��6   �� $ ModCmd�6�   �� 5#   
   $��Delete��61   $
��Left=�6B   $��42��6]   $��380,183,0,0q�6i   $	��Top=�6~   $	��104��6�   ��6   �� $ DelCmd�6�   5$      5%      