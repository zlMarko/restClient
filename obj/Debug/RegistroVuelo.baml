   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       AeronauticaCliente&    AeronauticaCliente.RegistroVuelo   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5        � WindowStartupLocation$  CenterScreen=�5      $��0q�5	      (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �  �� � 
ResizeMode$ NoResize=�5       � Title$ Registro Vuelo��5   	   $��448.695��6    $��579.451��61   ���	#FF078BA8.��5      � -   5         �Name$ _1231��5      $��0,0,2,2q�6   .+�5   
   �� -   5         ��Name$ 
PilotoText��5      $
��Left=�6'   $��23��6B   $��
152,22,0,0q�6N    �� TextWrapping$
 Wrap=�6b   $	��Top=�6v   $	��114��6�   �� 5   
   $��Piloto��6   $
��Left=�6!   $��	25,22,0,0q�6<   $	��Top=�6O   $��84��6g   �� 5   
   -   5        $ CopilotoText��5      $
��Left=�6)   $��23��6D   $��
152,69,0,0q�6P   $
 Wrap=�6d   $	��Top=�6x   $	��114��6�   �� 5   
   $��Copiloto��6   $
��Left=�6#   $��	25,69,0,0q�6>   $	��Top=�6Q   $��84��6i   �� 5   
   -   5         ��Name$ Condicion_Vuelo��5      $
��Left=�6,   $��152,157,0,0q�6G   $	��Top=�6\   $	��114��6t   $��26��6�   .@�5      �� $	��IFR��6   $
��Left=�6)   $	��118��6D   �� 5      $	��VFR��6   $
��Left=�6)   $	��118��6D   5      �� 5   
   $��Condición de vuelo��6   $
��Left=�6-   $��
25,157,0,0q�6H   $	��Top=�6\   $	��116��6t   �� 5   
   -   5        $ Piloto_Horas_Text��5      $
��Left=�6.   $��23��6I   $��152,200,0,0q�6U   $
 Wrap=�6j   $	��Top=�6~   $	��114��6�   �� 5   
   $��Horas Vuelo Piloto��6   $
��Left=�6-   $��
25,200,0,0q�6H   $	��Top=�6\   $	��109��6t   �� 5   
   -   5        $ Copiloto_Horas_Text��5      $
��Left=�60   $��23��6K   $��152,247,0,0q�6W   $
 Wrap=�6l   $	��Top=�6�   $	��114��6�   �� 5   
   $��Horas Vuelo Copiloto��6   $
��Left=�6/   $��
25,247,0,0q�6J   $	��Top=�6^   $	��127��6v   �� 5   
   -   5        $ 
OrigenText��5      $
��Left=�6'   $��23��6B   $��152,292,0,0q�6N   $
 Wrap=�6c   $	��Top=�6w   $	��114��6�   �� 5   
   $��Origen��6   $
��Left=�6!   $��
25,292,0,0q�6<   $	��Top=�6P   $��84��6h   �� 5   
   -   5        $ DestinoText��5      $
��Left=�6(   $��23��6C   $��152,334,0,0q�6O   $
 Wrap=�6d   $	��Top=�6x   $	��114��6�   �� 5   
   $��Destino��6   $
��Left=�6"   $��
25,334,0,0q�6=   $	��Top=�6Q   $��84��6i   �� 5   
   -	   5         ��Name$ MisionCompletaCheckBox��5      $��Misión Completada��63   $
��Left=�6O   $��152,390,0,0q�6j   $	��Top=�6   �� 5    
   -
   5        	 ��Name$	 RegistrarVuelo��5       $��Registrar Vuelo��6)   $
��Left=�6C   ���	#CC0078D7$��
374,45,0,0q�6u   $	��Top=�6�   $	��109��6�   $��50��6�   
 J� RenderTransformOrigin$
 0.5,0.5&�6�   6�   �� 5!   
   -   5        $	 LimpiarCampos_boton��5!      $��Limpiar Campos��6.   $
��Left=�6G   ���	#CC0078D7$��374,157,0,0q�6y   $	��Top=�6�   $	��109��6�   $��50��6�   $
 0.5,0.54&�6�   �� 5"   
   -   5        $	 Salir��5"      $��Salir��6    $
��Left=�60   ���	#CC0078D7$��374,268,0,0q�6b   $	��Top=�6w   $	��109��6�   $��50��6�   $
 0.5,0.54&�6�   6�   �� 5#   
   -   5        $ AeronaveText��5#      $
��Left=�6)   $��23��6D   $��152,110,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��114��6�   �� 5$   
   $��Patente Aeronave��6   $
��Left=�6+   $��
25,110,0,0q�6F   $	��Top=�6Z   $	��109��6r   5'      5(      