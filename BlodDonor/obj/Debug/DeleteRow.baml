   M S B A M L   `   `   `  ����D  @BlodDonor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:BlodDonor	BlodDonor  5   	       BlodDonor.DeleteRow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:BlodDonor     5   	   -   5          � WindowStartupLocation$  CenterScreen=�5	   	    � Icon$ bin.png��5
   	    � Title$ Delete donor��5   	   $��349.721��6   $��330.5��6/   .��5      �  � RowDefinitions 5   
   �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��DataGrid��5   *      CanUserAddRows .     ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$ * 6:   $
��Left=�6J   $	��100��6e   $��	8,130,0,0q�6r   $	��Top=�6�   $	��302��6�   �� 5   
   $
��Name��6   $
��Left=�6   $��	10,12,0,0q�6:   $	��Top=�6M   $��92��6e   $��26��6p   �� 5   
   $��Surname��6   $
��Left=�6"   $��9,45,0,0q�6=   $	��Top=�6O   $��92��6g   $��26��6r   �� 5   
   -   5        $��nameL��5      $
��Left=�6   $��23��6:   $��	82,12,0,0q�6F    �� TextWrapping$
 Wrap=�6Y   $��------��6m    �� TextAlignment$ Center=�6{   $	��Top=�6�   $	��120��6�   .��6�   ��5      �� 5       �� Color# � ��6"   .��5   "   5      �� 5   
   -   5        $��surameL��5      $
��Left=�6!   $��23��6<   $��	82,45,0,0q�6H   $
 Wrap=�6[   $��------��6o   $ Center=�6}   $	��Top=�6�   $	��120��6�   .��6�   ��5      �� 5      # � ��6"   .��5   "   5      �� 5   
   -   5        $��peselL��5      $
��Left=�6    $��24��6;   $��	82,78,0,0q�6G   $
 Wrap=�6Z   $��------��6n   $ Center=�6|   $	��Top=�6�   $	��120��6�   .��6�   ��5      �� 5      # � ��6"   .��5    "   5!      �� 5"   
   -   5        $��Delete��5"      $
��Left=�6"   $��
39,258,0,0q�6=   $	��Top=�6Q   $��75��6i   $��20��6t   6�   �� 5#   
   -   5        $��Dismiss��5#      $
��Left=�6#   $��190,258,0,0q�6>   $	��Top=�6S   $��75��6k   $��20��6v   6�   �� 5$   
   $	��SSN��6   $
��Left=�6   $��9,78,0,0q�69   $	��Top=�6K   $��92��6c   $��26��6n   �� 5%   
   -   5        $��Search��5%      $
��Left=�6"   $��
228,44,0,0q�6=   $	��Top=�6Q   $��75��6i   $��20��6t   6�   5'      5(      