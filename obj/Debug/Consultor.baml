   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=2.0.0.0, Culture=neutral, PublicKeyToken=51482d6f650b2b3fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5      V;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5       AeronauticaCliente"   AeronauticaCliente.Consultor   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Pcontrols;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Kmah;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      b ^MaterialDesignThemes.Wpf, Version=4.1.0.2556, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesing1http://materialdesigninxaml.net/winfx/xaml/themes  5        � WindowStartupLocation$  CenterScreen=�5	      $��0q�5      (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �  �� � 
ResizeMode$ NoResize=�5       � Title$ Aeronautica-DGAC��5   	   $	��475��6"   $��798.833��6/   ���	#FF078BA8.��5      � $��	0,0,-18,0q�6   .+�5   
   � -   5         �Name$ print��5      ���	#FF078BA8$	��446��65   $	��Top=�6B   .+�5      !   MahApps.Metro.Controls.Tile  $
��Left=�6   $��0q�62   $	��Top=�6=   $	��198��6U   $	��446��6a   �� 5      -   5         ��Name$ ReporteBoton��5      $��Generar Reporte��6+   $
��Left=�6E   ���	#CC0078D7$��
16,390,0,0q�6w   $	��Top=�6�   $	��171��6�   $��35��6�   6�   �� 5      $�� ��6   $
��Left=�6!   $��10,0,0,0q�6<   $	��Top=�6N   $��81��6f   $	��141��6q   ���	#FF078BA8��5      �� 5       �� ImageSource$ download.png��6!    j� TileMode$
 Tile=�6<    j� Stretch$ UniformToFill=�6L   5        5      -   5        	  Name$	 NombreConsultor��5      $�� ��60   $
��Left=�6;   $��
106,36,0,0q�6V   $	��Top=�6j   $��81��6�   $��15��6�     5      -   5        $	 ApellidoConsultor��5      $�� ��62   $
��Left=�6=   $��
106,61,0,0q�6X   $	��Top=�6l   $��81��6�   $��15��6�   �� 5      $��Matricula aeronave��6   $
��Left=�61   $��
240,50,0,0q�6L   $	��Top=�6`   $	��125��6x   �� 5      $��Fecha de mantencion��6   $
��Left=�62   $��
33,158,0,0q�6M   $	��Top=�6a   $	��125��6y   &   System.Windows.Controls.Calendar  5      -   5        
  Name$
 fechaMantenimiento��5      $
��Left=�63   $��	9,188,0,0q�6N   $	��Top=�6a   $	��196��6y   $	��179��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5      V� 5      .~�5       �� �� 5!       �� AngleY$ 0.295Q�6(   �� 5"      T� 5#       T� Y$ 0.495Q�6-   5$      5&      �� 5'      $��Técnico a cargo��6   $
��Left=�6.   $��
600,58,0,0q�6I   $	��Top=�6]   $	��125��6u   �� 5(      -   5         ��Name$ tecnicoEncargado��5(      $
��Left=�60   $��23��6K   $��
600,90,0,0q�6W    �� TextWrapping$
 Wrap=�6k   $	��Top=�6   $	��120��6�   �� 5)      -   5        $ horasVueloA��5)      $
��Left=�6+   $��23��6F   $��
424,90,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��120��6�   �� 5*      $��Horas de vuelo��6   $
��Left=�6-   $��
424,50,0,0q�6H   $	��Top=�6\   $	��125��6t   �� 5+      $��Detalle del mantenimietno��6   $
��Left=�68   $��214,180,0,0q�6S   $	��Top=�6h   $	��161��6�   �� 5,      -   5        $ detalleMantencion��5,      $
��Left=�61   $	��214��6L   $��214,211,0,0q�6Y   $
 Wrap=�6n   $	��Top=�6�   $	��480��6�   �� 5-      -	   5        $ matriculaAeronave��5-      $
��Left=�61   $��23��6L   $��
240,90,0,0q�6X   $
 Wrap=�6l   $	��Top=�6�   $	��120��6�   5/      50      51      