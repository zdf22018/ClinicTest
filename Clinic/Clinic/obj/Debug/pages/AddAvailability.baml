   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:ClinicClinic  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5          Clinic.AddAvailability   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      &localclr-namespace:Clinic     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  AddAvailability��5
       � 	Resources 5         doctorViewSource " doctoravailabilitiesViewSource �� Source �� Source��%_   &	        &	      7   �� 5   
   6   �� 5   
    6F   �� *availabilities+8   5      .��5      �  � DataContext# [ 6   $	��700��6I   .+�5   
   �� -   5         ��Name$ label��5      $��Add Availability��6   $
��Left=�6:   $��
102,66,0,0q�6U   $	��Top=�6i   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpDateAddAv��5      $
��Left=�6+   $��102,104,0,0q�6F   $	��Top=�6[   �� 5   
   -   5        $ label1��5      $��
Start Time��6    $
��Left=�65   $��102,143,0,0q�6P   $	��Top=�6e   �� 5   
   -   5         ��Name$ cmbStartTime��5      $
��Left=�6)   $��165,153,0,0q�6D   $	��Top=�6Y   $	��120��6q   .@�5      �� $
��8:00��6   �� 5      $
��9:00��6   �� 5      $��10:00��6   �� 5      $��11:00��6   �� 5      $��12:00��6   �� 5      $��13:00��6   �� 5      $��14:00��6   �� 5      $��15:00��6   �� 5      $��16:00��6   �� 5      $��16:00��6   5       �� 5"   
   -   5        $ label2��5"      $��End Time��6    $
��Left=�63   $��107,199,0,0q�6N   $	��Top=�6c   �� 5#   
   -   5        $ 
cmbEndTime��5#      $
��Left=�6'   $��165,199,0,0q�6B   $	��Top=�6W   $	��120��6o   .@�5$      �� $
��9:00��6   �� 5%      $��10:00��6   �� 5&      $��11:00��6   �� 5'      $��12:00��6   �� 5(      $��13:00��6   �� 5)      $��14:00��6   �� 5*      $��15:00��6   �� 5+      $��16:00��6   �� 5,      $��17:00��6   5-      �� 5.   
   -   5         ��Name$ btAdd��5.      $	��Add��6    $
��Left=�6.   $��107,296,0,0q�6I   $	��Top=�6^   $��75��6v   6�   	� 5/   
   -	   5        	 	�Name$	 rb30M��5/      $��
30 minutes��6%   
 	� 	GroupName$
 duration��6:   $
��Left=�6O   $��180,262,0,0q�6j   $	��Top=�6   	� 50   
   -
   5        $	 rb60M��50      $��
60 minutes��6&   $
 duration��6;   $
��Left=�6P   $��285,262,0,0q�6k   $	��Top=�6�   �� 51   
   $��Duration��6   $
��Left=�6#   $��100,257,0,0q�6>   $	��Top=�6S    J� RenderTransformOrigin$ -3.013,0.109&�6k   &   System.Windows.Controls.DataGrid  52   
   -   5          Name$ availabilitiesDataGrid��52         AutoGenerateColumns .     EnableRowVirtualization . $��403,94,54,156q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   $	��400��6�   ��6n   ��    Columns 53      0  *System.Windows.Controls.DataGridTextColumn  54      -   5        doctorIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 	Doctor Id��54   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
DoctorId+6m     55      -   5        availableFromColumn��$ Available From��55   d   $
 auto 6|    6B   �� *AvailableFrom+6|     56      -   5        availableToColumn��$ Available To��56   `   $
 auto 6v    6@   �� *AvailableTo+6v   59      5:      5;      