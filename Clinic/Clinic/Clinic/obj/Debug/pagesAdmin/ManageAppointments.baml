   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Clinic.pagesAdminClinic.pagesAdmin  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5      *    $Clinic.pagesAdmin.ManageAppointments   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Clinic.pagesAdmin     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  ManageAppointments��5
       � 	Resources 5         doctor_scheduleViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   $��
0,0,0,-210q�6D   .+�5   
   �� $
��From��6   $
��Left=�6   $��
312,88,0,0q�6:   $	��Top=�6N   (  "System.Windows.Controls.DatePicker  5   
   -   5          Name$ dpFrom��5      $
��Left=�6%   $��
378,93,0,0q�6@   $	��Top=�6T   6l   �� 5   
   $��To��6   $
��Left=�6   $��
540,89,0,0q�68   $	��Top=�6L     5   
   -   5        $
 dpTo��5      $
��Left=�6#   $��
593,89,0,0q�6>   $	��Top=�6R   6j   �� 5   
   $��Doctor Name��6   $
��Left=�6&   $��
72,110,0,0q�6A   $	��Top=�6U   �� 5   
   -   5         ��Name$ TBName��5      $
��Left=�6"   $��23��6=   $��160,110,0,0q�6I    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ doctor_scheduleDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��69,190,210,232q�6�   	   RowDetailsVisibilityMode$	 VisibleWhenSelected=�6�   ��6o   �� 
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        doctorIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ 	Doctor Id��5   Z      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6m   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6=   �� *
DoctorId+6m     5      -   5        doctorNameColumn��$ Doctor Name��5   ^   $ * 6s    6?   �� *
DoctorName+6s     5      -   5        patientIdColumn��$ 
Patient Id��5   \   $ 40 6p    6>   �� *	PatientId+6p     5      -	   5        patientNameColumn��$ Patient Name��5   `   $ * 6v    6@   �� *PatientName+6v     5      -
   5        slotStartColumn��$ 
Slot Start��5   \   $ * 6p    6>   �� *	SlotStart+6p     5      -   5        slotEndColumn��$ Slot End��5   X   $ * 6j    6<   �� *	SlotEnd+6j   5       �� 5!   
   -   5         ��Name$ btUpdate��5!      $��Update Appointment��6#   $
��Left=�6@   $��617,190,0,0q�6[   $	��Top=�6p   $��75��6�   6�   �� 5"   
   -   5        $ btDelete��5"      $��Delete Appointment��6#   $
��Left=�6@   $��617,239,0,0q�6[   $	��Top=�6p   $��75��6�   6�   �� 5#   
   -   5        $ btAdd��5#      $��Add Appointment��6    $
��Left=�6:   $��617,291,0,0q�6U   $	��Top=�6j   $��75��6�   �� 5$   
   $��Label��6   $
��Left=�6    $��	74,75,0,0q�6;   $	��Top=�6N   �� 5%   
   -   5        $ TBPatientName��5%      $
��Left=�6*   $��23��6E   $��
160,75,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   6�   5'      5(      