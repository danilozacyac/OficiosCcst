   M S B A M L   `   `   `  ����  OficiosCcst    OficiosCcst.Oficio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      k gTelerik.Windows.Controls.Input, Version=2014.2.729.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7m iTelerik.Windows.Controls.Docking, Version=2014.2.729.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7a ]Telerik.Windows.Data, Version=2014.2.729.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7e aTelerik.Windows.Controls, Version=2014.2.729.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7p	 lTelerik.Windows.Controls.Navigation, Version=2014.2.729.45, Culture=neutral, PublicKeyToken=5803cfa389c90ce7Gtelerik1http://schemas.telerik.com/2008/xaml/presentation     	 5      -   5        $	��854��5      $	��620��5      $��Oficio��5      .��5
      � .+�5   
   �� $��	42,34,0,0q�5      $
��Left=�5      $	��Top=�5      $��Libro:��5      *  $Telerik.Windows.Controls.RadComboBox  5   
   -   5           Name$  CbxLibro��5      $��50��5      $��	86,34,0,0q�5      $
��Left=�5      $	��Top=�5      ��5      �� 6%   �� 5   
   $��	43,89,0,0q�5      $
��Left=�5      $	��Top=�5      $��Adscripción:��5        5   
   -   5        $  CbxAdscripcion��5      $	��217��5      $��
122,93,0,0q�5       �� DisplayMemberPath$ Adscripcions��5!       �� SelectedValuePath$ IdAdscripcion��5"      $
��Left=�5#      $	��Top=�5$      ��5       �� 5%      �� 5&   
   $��
407,89,0,0q�5'      $
��Left=�5(      $	��Top=�5)      $��Destintario(s):��5*      �� 5+   
   -   5         ��Name$ TxtDestinatario��5,      $	��264��5-      $��23��5.      $��
495,92,0,0q�5/      $
��Left=�50      $	��Top=�51      {�.   �� TextWrapping$
 Wrap=�53      �� 54   
   -   5         ��Name$ BtnDestinatarios��55      $��21��56      $��
764,93,0,0q�57      $
��Left=�58      $	��Top=�59      $	��...��5:      �� 5;   
   $��
43,154,0,0q�5<      $
��Left=�5=      $	��Top=�5>      $��Ident. Archivística:��5?      �� 5@   
   -   5        $ TxtIdentidad��5A      $	��341��5B      $��23��5C      $��153,154,0,0q�5D      $
��Left=�5E      $	��Top=�5F      {�.   J� RenderTransformOrigin$ 0.5,0.5&�5H      $
 Wrap=�5I      .��6!   z�5J      V� 5K      .~�5L      �� �� 5M      �� 5N       �� Angle$ 0.144Q�6&   T� 5O      5P      .��5Q   '   5R      �� 5S   
   -   5        $ BtnIdentidad��5T      $��27��5U      $��499,154,0,0q�5V      $
��Left=�5W      $	��Top=�5X      $	��...��5Y      �� 5Z   
   $��
43,206,0,0q�5[      $
��Left=�5\      $	��Top=�5]      $��Fecha del oficio:��5^      ,  &Telerik.Windows.Controls.RadDatePicker  5_   
   -   5          Name$ DtpFechaOficio��5`      $	��140��5a      $��155,206,0,0q�5b      $
��Left=�5c      $	��Top=�5d      �� 5e   
   $��407,204,0,0q�5f      $
��Left=�5g      $	��Top=�5h      $��Asunto:��5i        5j   
   -	   5        $  	CbxAsunto��5k      $	��264��5l      $��495,206,0,0q�5m      $
��Left=�5n      $	��Top=�5o      .@�5p      .  (Telerik.Windows.Controls.RadComboBoxItem  $��Item 1��6&     5q      $��Item 2��6&     5r      $��Item 3��6&     5s      $��Item 1��6&     5t      $��Item 2��6&     5u      $��Item 3��6&   5v      �� 5w   
   $��
43,273,0,0q�5x      $
��Left=�5y      $	��Top=�5z      $��Resumen:��5{      �� 5|   
   $	��742��5}      $	��188��5~      $��
43,315,0,0q�5      $
��Left=�5�      $	��Top=�5�      	 �� AcceptsReturn	 . 
 �� 
AcceptsTab
 . $
 Wrap=�5�      �� 5�   
   -
   5        $ BtnCancelar��5�      $	��106��5�      $��43��5�      $��679,525,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Cancelar��5�       �� IsCancel . 5�      �� 5�   
   -   5        $ 
BtnGuardar��5�      $	��106��5�      $��43��5�      $��568,525,0,0q�5�      $
��Left=�5�      $	��Top=�5�      $��Guardar��5�       . 5�      �� 5�   
   -   5        $ BtnGuardarDoc��5�      $	��106��5�      $��43��5�      $��457,525,0,0q�5�      $
��Left=�5�      $	��Top=�5�       . .��5�      ��  �� Orientation$ Vertical=�6   .+�5�      �� $��Center=�6   $��	Guardar y��69   �� 5�      $��Center=�6   $��generar Word��69   5�      5�      5�      5�      