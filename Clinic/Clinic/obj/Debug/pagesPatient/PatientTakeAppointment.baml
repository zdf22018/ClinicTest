   M S B A M L   `   `   `  ����A  =Clinic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:Clinic.pagesPatientClinic.pagesPatient  5      > :DAL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null&clr-namespace:DAL;assembly=DALDAL 5      0    *Clinic.pagesPatient.PatientTakeAppointment   5      a ]DevExpress.Xpf.Core.v17.2, Version=17.2.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:Clinic.pagesPatient     5      .DALclr-namespace:DAL;assembly=DAL     5      -   5          N� Title$  PatientTakeAppointment��5
       � 	Resources 5       %  !display_available_slotsViewSource��%   &	        �� 5   
   6   5      .��5      �  � DataContext# [  6   $	��500��6L   $
��1000��6Y   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$% display_available_slotsDataGrid��5         AutoGenerateColumns .     EnableRowVirtualization . $��57,53,397,50q�6�      RowDetailsVisibilityMode$ VisibleWhenSelected=�6�    J� RenderTransformOrigin$ 0.508,0.725&�6�   ��6w   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        doctorColumn��,  &System.Windows.Controls.DataGridColumn	   Header$	 Doctor��5   ?   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6O      CellTemplate 5      �� 5      .R�5      �� ��6$   �� *Doctor+5      5        5      -   5        startColumn��$	 Start��5   >   $
 * 6M    5      �� 5      .R�5      �� ��6$   �� *Start+5      5        5       -   5        	endColumn��$		 End��5    <   $
 * 6I    5!      �� 5"      .R�5#      �� ��6$   �� *End+5$      5&        5'      -   5        timeSoltIdColumn��$	 Time Solt Id��5'   C   $
 75 6Y    5(      �� 5)      .R�5*      �� ��6$   �� *
TimeSoltId+5+      5-      5/      �� 50   
   $��Doctor��6   $
��Left=�6!   $��	57,17,0,0q�6<   $	��Top=�6O   $��62��6g   �� 51   
   -   5         ��Name$ tbName��51      $
��Left=�6#   $��23��6>   $��
104,18,0,0q�6J    �� TextWrapping$
 Wrap=�6^   $�� ��6r   $	��Top=�6z   $	��120��6�   (  "System.Windows.Controls.DatePicker  52   
   -   5          Name$ dpFrom��52      $
��Left=�6%   $��
297,18,0,0q�6@   $	��Top=�6T   �� 53   
   $��To��6   $
��Left=�6   $��
432,20,0,0q�68   $	��Top=�6L   $��27��6d     54   
   -	   5        $
 dpTo��54      $
��Left=�6#   $��
474,18,0,0q�6>   $	��Top=�6R   $	��129��6k   �� 55   
   -
   5         ��Name$ btTakeAppointment��55      $&�� take Appointment for chosen spot��6-   $
��Left=�6X   $��
608,53,0,0q�6s   $	��Top=�6�   $	��180��6�   6�   �� 56   
   $
��From��6   $
��Left=�6   $��
264,17,0,0q�6:   $	��Top=�6N   �� 57   
   -   5        $ btSearch��57      $��Search��6#   $
��Left=�64   $��
625,20,0,0q�6O   $	��Top=�6c   $	��130��6{   6�   5:      5<      