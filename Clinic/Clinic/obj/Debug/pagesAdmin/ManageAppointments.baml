   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Clinic.pagesAdminClinic.pagesAdmin  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5      *    $Clinic.pagesAdmin.ManageAppointments   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      1localclr-namespace:Clinic.pagesAdmin     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  ManageAppointments��5
       � 	Resources 5         doctor_scheduleViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   $	��611��6D   $	��Top=�6Q   $��
0,0,0,-161q�6i   .+�5   
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
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   6�   �� 5   
   -   5         ��Name$ btDelete��5      $��Delete Appointment��6#   $
��Left=�6@   $��685,217,0,0q�6[   $	��Top=�6p   $	��145��6�    J� RenderTransformOrigin$ 0.838,0.182&�6�   �� 5   
   -   5        $ btAdd��5      $��Add Appointment��6    $
��Left=�6:   $��685,264,0,0q�6U   $	��Top=�6j   $	��145��6�   6�   �� 5   
   $��Patient��6   $
��Left=�6"   $��	74,75,0,0q�6=   $	��Top=�6P   �� 5   
   -   5        $ TBPatientName��5      $
��Left=�6*   $��23��6E   $��
160,75,0,0q�6Q   $
 Wrap=�6e   $�� ��6y   $	��Top=�6�   $	��120��6�   6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ doctor_scheduleDataGrid��5      	   AutoGenerateColumns	 .  
   EnableRowVirtualization
 . $��10,147,188,182q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�   ��6o   ��    ColumnHeaderStyle 5      �� 5       �� 
TargetType=  7System.Windows.Controls.Primitives.DataGridColumnHeader"  6   .�5      ��  �� Property � �� �� Value 5       �� 5!      .R�5"   "   �� $
��Wrap=�6,   ��6@   �� 6S   5#      5%      5&         Columns 5)      4  .System.Windows.Controls.DataGridTemplateColumn  5*      -	   5        appointmentIdColumn��,  &System.Windows.Controls.DataGridColumn   Header$ appointment Id��5*   F      Width5  /System.Windows.Controls.DataGridLengthConverter$ 40 6^      CellTemplate 5+      �� 5,      .R�5-      �� ��6$   �� *appointmentId+5.      50        51      -
   5        doctorColumn��$ Doctor��51   ?   $	 100 6O    52      �� 53      .R�54      �� ��6$   �� *Doctor+55      57        58      -   5        doctorIdColumn��$ 	Doctor Id��58   A   $ 40 6T    59      �� 5:      .R�5;      �� ��6$   �� *
DoctorId+5<      5>        5@      -   5        patientColumn��$ Patient��5@   @   $	 100 6Q    5A      �� 5B      .R�5C      �� ��6$   �� *	Patient+5D      5F        5G      -   5        patientIdColumn��$ 
patient Id��5G   B   $ 40 6V    5H      �� 5I      .R�5J      �� ��6$   �� *	patientId+5K      5M      0  *System.Windows.Controls.DataGridTextColumn  5N      -   5        startColumn��$ Start��5N   T   $	 130 6c   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *Start+6c     5O      -   5        	endColumn��$	 End��5O   P   $	 130 6]    68   �� *End+6]   5Q      5S      5T      