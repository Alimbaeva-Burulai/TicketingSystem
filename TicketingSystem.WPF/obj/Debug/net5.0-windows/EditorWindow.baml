   M S B A M L   `   `   `  ����N  JTicketingSystem.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TicketingSystem.WPF.UITicketingSystem.WPF.UI  5   	   ?$clr-namespace:TicketingSystem.WPF.VMTicketingSystem.WPF.VM  5   	   &     TicketingSystem.WPF.EditorWindow   5   	   \ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-mamespace:TicketingSystem.WPF     5   	   3ui$clr-namespace:TicketingSystem.WPF.UI     5   	   3vm$clr-namespace:TicketingSystem.WPF.VM     5   	     � Title$  EditorWindow��5
   	   $	��420��6   $	��398��6+    � 	Resources 5      5   /TicketingSystem.WPF.UI.CardTypeToBrushConverter   CardTypeToBrushConverter,  &TicketingSystem.WPF.VM.EditorViewModel  VM��%:   &	        &	        5   
   6&     5   
   6   5      .��5      �  � DataContext# [ 6    � ColumnDefinitions 5   
   �� 5      $	��67* �6   �� 5      $	��48* �6   �� 5      $��0* �6   .+�5   
   �� $��Name :��6   $
��Left=�6!   $��27��6<   $��	51,48,0,0q�6H   $	��Top=�6[   $��53��6s   �� 5   
   $��	Address :��6   $
��Left=�6$   $��27��6?   $��	51,93,0,0q�6K   $	��Top=�6^   $��53��6v   �� 5   
   $��Type of bank card :��6   $
��Left=�6.   $��26��6I   $��
51,136,0,0q�6U   $	��Top=�6i   $	��114��6�   �� 5   
   $��Insurance :��6   $
��Left=�6&   $��27��6A   $��
51,172,0,0q�6M   $	��Top=�6a   $��86��6y   �� 5   
   $��Salary :��6   $
��Left=�6#   $��27��6>   $��
51,210,0,0q�6J   $	��Top=�6^   $��86��6v   �� 5   
   $
��Left=�65   $��26��6P   $��3,48,0,0q�6\    �� TextWrapping$
 Wrap=�6n   $	��Top=�6�   $	��100��6�   $��1��6�   ��6   ��  �� Path$ Cashier.Name�6�   �� 5   
   $
��Left=�68   $��21��6S   $��3,93,0,0q�6_   $
 Wrap=�6q   $	��Top=�6�   $	��100��6�   $��1��6�   ��6   �� $ Cashier.Address�6�   �� 5   
   $
��Left=�69   $��20��6T   $��	3,136,0,0q�6`   $
 Wrap=�6s   $	��Top=�6�   $	��100��6�   $��1��6�   ��6   �� $ Cashier.CardType�6�   �� 5   
   $
��Left=�6:   $��21��6U   $��	3,178,0,0q�6a   $
 Wrap=�6t   $	��Top=�6�   $	��100��6�   $��1��6�   ��6   �� $ Cashier.Insurance�6�   �� 5    
   $
��Left=�67   $��20��6R   $��	3,217,0,0q�6^   $
 Wrap=�6q   $	��Top=�6�   $	��100��6�   $��1��6�   ��6   �� $ Cashier.Salary�6�   �� 5"   
   -   5        $��OK��5"      $��Center=�6   $��44��6;   $��	0,287,0,0q�6G   $	��Top=�6Z   $��76��6r   6}   �� 5#   
   -   5        $��CANCEL��5#      $
��Left=�6"   $��44��6=   $��
27,282,0,0q�6I   $	��Top=�6]   $��76��6u   $��1��6�   5$      5%      