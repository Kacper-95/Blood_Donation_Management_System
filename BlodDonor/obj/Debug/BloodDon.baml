   M S B A M L   `   `   `  ����D  @BlodDonor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlodDonor	BlodDonor  5   	       BlodDonor.BloodDon   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BlodDonor     5   	   -   5          � Icon$  plus-sign.png��5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ Add donation��5   	   $��460.5��6   $	��422��6-   .��5      � .+�5   
   �� $
��Name��6   $
��Left=�6   $��4,18,0,0q�6:   $	��Top=�6L   $��49��6d   �� 5   
   $��Surname��6   $
��Left=�6"   $��6,50,0,0q�6=   $	��Top=�6O   $��59��6g   �� 5   
   $��Blood donation��6   $
��Left=�6)   $��	8,239,0,0q�6D   $	��Top=�6W   $��96��6o   &   System.Windows.Controls.DataGrid  5   
   -   5        $��DataGrid��5   U      CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6*      AutoGenerateColumns . $
��Left=�6e   $	��126��6�   $��5,93,0,0q�6�   $	��Top=�6�   $	��398��6�   �� 5   
   $	��SSN��6   $
��Left=�6   $��
201,22,0,0q�69   $	��Top=�6M   $��41��6e   �� 5   
   -   5        $��NameTB��5      $
��Left=�6    $��23��6;    �� TextWrapping$
 Wrap=�6G   $�� ��6[   $	��Top=�6c   $	��120��6{   $��	69,23,0,0q�6�   �� 5   
   -   5        $��	SurnameTB��5      $
��Left=�6#   $��23��6>   $��	69,54,0,0q�6J   $
 Wrap=�6]   $�� ��6q   $	��Top=�6y   $	��120��6�   �� 5   
   -   5        $��PeselTB��5      $
��Left=�6!   $��23��6<   $
 Wrap=�6H   $�� ��6\   $	��Top=�6d   $	��120��6|   $��
246,23,0,0q�6�   �� 5   
   -   5        $��LitersTB��5      $
��Left=�6"   $��23��6=   $��105,242,0,0q�6I   $
 Wrap=�6^   $�� ��6r   $	��Top=�6{   $��53��6�   �� 5   
   $��(in liters)��6   $
��Left=�6&   $��169,241,0,0q�6A   $	��Top=�6V   $��57��6n   �� 5   
   -   5        $��SearchB��5   "   $��Search��6   $
��Left=�61   $��
261,58,0,0q�6L   $	��Top=�6`   $��75��6x   6�   �� 5   
   -   5        $��UpdateB��5   #   {�.  $��Update��62   $
��Left=�6C   $��288,247,0,0q�6^   $	��Top=�6s   $��75��6�   6�   5      5      