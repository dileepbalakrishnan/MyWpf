   M S B A M L   `   `   `  ����G  CCommandsDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:CommandsDemoCommandsDemo  5   	       CommandsDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:CommandsDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    J� CommandBindings 5	      )  #System.Windows.Input.CommandBinding  5
   
   -   5           Command$
 Open��5
      6<     5   
   -   5        $ DecreaseZoom��5      6f     5   
   -   5        $ IncreaseZoom��5      6f     5   
   -   5        $&  local:Commands.ZoomNormalCommand��5      6t   .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      6   .+�5   
   c� $��15(�6   .@�5      �� $��Open...��6   $
��Open��6'   $��6q�66   6C   �� 5      $��Zoom In��6   $��IncreaseZoom��6'   $��6q�6>   6K   �� 5      $��Zoom Out��6   $��DecreaseZoom��6(   $��6q�6?   6L   �� 5      $��Original��6   $&�� local:Commands.ZoomNormalCommand��6(   $��6q�6S   6`   5      �� 5   
   $��1��6   $
��Auto=�6$   $
��Auto=�6G   .��5      �� $
��None=�61   ��6   �� *	ImagePath+ � LayoutTransform 5      �� 5       �� ScaleX 6%   �� *Zoom+ �� ScaleY 6=   �� *Zoom+5      5       5!      5"      5#      