   M S B A M L   `   `   `  ����  M.Luthfi Azzammi+    %M.Luthfi_Azzammi.ViewPemakaianBarang2   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � Title$  View Pemakaian Barang��5      $	��650��6#   $	��700��63   $	��900��6C   $
��1000��6R    � WindowStartupLocation$ CenterScreen=�6b    � Icon$< 6/M.Luthfi Azzammi;component/Resources/jenislaundry.png��6�   .��5      � .+�5   
   �� ���	#FF543EE2$��Stretch=�6%   $	��Top=�6C   $��60��6[   �� 5   
   $��View Pemakaian Barang��6   $
��Left=�60   $��43��6K   $��	10,10,0,0q�6W   $	��Top=�6j   $	��362��6�   $��Verdana)�6�   $��27(�6�   
�������6�   �� 5   
   $��0q�6   $��
10,65,10,0q�6'   ���	#FF5F63BB$	��Top=�6R   $��Stretch=�6j   $��59��6�   .��5	      � $
��Left=�6   $	��Top=�6.   .+�5
      �� $
��Cari��6   $
��Left=�6'   $��10,9,0,0q�6B   $	��Top=�6T   
�������$��20(�6   �� 5      -   5        $��CariTxt��5      $
��Left=�6)   $��43��6D   $��	59,10,0,0q�6P    �� TextWrapping$
 Wrap=�6c   $	��Top=�6w   $	��232��6�   $��Verdana)�6�   $��18(�6�   $��7q�6�   �� 5      $.��(* Pencarian Menggunakan Kode Pengeluaran��6   $
��Left=�6K   $��
296,18,0,0q�6f   $	��Top=�6z   
���  ��$��Italic$�6�   $��12(�6�   �� 5      -   5        $��
RefreshBtn��5      $��Refresh��6+   $
��Left=�6=   $��	645,9,0,0q�6X   $	��Top=�6k   $��75��6�   $��33��6�   5      5      �� 5   
   $��0q�6   $��10,129,10,59q�6'   ���	#FFF0EAEA$��Stretch=�6T   $��Stretch=�6r   .��5      &   System.Windows.Controls.DataGrid  -   5        $	��DG1��5      $��0,10,0,4q�6"   $��verdana)�64   $��15(�6I      GridLinesVisibility$ Vertical=�6W      VerticalGridLinesBrush �	#FFE4E4E46v   5      �� 5   
   $��-21,0,-19,-11q�6   $��0q�6*   $��Bottom=�6>   $��Stretch=�6Y   $��65��6w   .��5      � ���	#FF40D19C$��0,0,0,4q�6*   $��Stretch=�6;   $��Center=�6Y   .+�5      �� -   5        $��	SimpanBtn��5      $��0,10,504,10q�6*   $��Right=�6?   .��5      � $	��148��6   $��Center=�6'   $��Center=�6D   $��48��6_   .+�5      �� $��
10,10,0,10q�6    $6��0/M.Luthfi Azzammi;component/Resources/tambah.png��64   $��Center=�6n   $
��Left=�6�   $��28��6�   �� 5      $��Tambah��6    $��47,10,27,12q�61   $��Georgia)�6F   $��16(�6[   5      5      �� 5      -   5        $��EditBtn��5      $��0,10,345,10q�6(   $��Right=�6=   .��5      � $	��148��6   $��Center=�6'   $��Center=�6D   $��48��6_   .+�5      �� $��
10,10,0,10q�6    $4��./M.Luthfi Azzammi;component/Resources/edit.png��64   $��Center=�6l   $
��Left=�6�   $��28��6�   �� 5      $
��Edit��6    $��47,10,27,12q�6/   $��Georgia)�6D   $��16(�6Y   5      5       �� 5!      -   5        $��HapusBtn��5!      $��0,10,186,10q�6)   $��Right=�6>   .��5"      � $	��148��6   $��Center=�6'   $��Center=�6D   $��48��6_   .+�5#      �� $��
10,10,0,10q�6    $;��5/M.Luthfi Azzammi;component/Resources/recycle_bin.png��64   $��Center=�6s   $
��Left=�6�   $��28��6�   �� 5$      $��Hapus��6    $��47,10,27,12q�60   $��Georgia)�6E   $��16(�6Z   5%      5&      �� 5'      -   5        $��BatalBTn��5'      $��629,10,22,10q�6)   $��Right=�6?   .��5(      � $	��148��6   $��48��6'   $��Center=�63   $��Center=�6P   .+�5)      �� $��0,10,106,10q�6    $��../Resources/delete2.png��65   �� 5*      $��Batal��6    $��47,10,27,12q�60   $��Georgia)�6E   $��16(�6Z   5+      5,      5-      5.      5/      50      