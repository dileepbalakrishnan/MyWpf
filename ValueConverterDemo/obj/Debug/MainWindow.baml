   M S B A M L   `   `   `  ����M  IValueConverterDemo, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:ValueConverterDemoValueConverterDemo  5   	   #    ValueConverterDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:ValueConverterDemo     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � 	Resources 5	      1   +ValueConverterDemo.ForecastToBrushConverter   forecast2Brush��%   &	          5
   
   6B   5      .��5      �  � RowDefinitions 5   	   �� 5      $
��Auto �6   6+   �� 5      $
��Auto �6   6+   �� 5      6   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $��15(�6   $��Center=�6&   $��4q�6A   $!��Number of days to forecast:��6L   6q   �� 5      -   5        $��cmbDays��5      $��50��6&    �� SelectedIndex$ 0��61   6E   �� 5      -   5        $��Get Forecast��5      $��4q�6,   $��16(�67   6b   5      �� 5   
   $ 
Horizontal=�6   $��1��6.   $��4q�6;   .+�5      �� $��15(�6   $��Center=�6&   $��4q�6A   $��Select Unit:��6L   6b   	� 5       d� 	IsChecked$
 TrueY�6   $��Celsius��6+   $��15(�6=   6N   	� 5      $��
Fahrenheit��6   $��15(�6/   6?   5      �� 5   
   $��2��6   .+�5      �� $��Stretch=�6.   ��6   �� ��5      �� 5      .R�5       �� 
���   �$��2q�65   ��6I   �� *GeneralForecast+ �� 	Converter# [  ._�5!      �� $ 
Horizontal=�6)   .+�5"   "   �� $��17(�6,   $��30��6:   $	��Top=�6F   $
��Bold"�6   ��6^   �� *GeneralForecast+6�   �� 5#   "   $��10,0,0,0q�6,   $��30��6>   $��Bottom=�6J   ��6e   �� *TemperatureLow+ �� StringFormat$ 	Low : {0}��6�   �� 5$   "   $��10,0,0,0q�6,   $��30��6>   $��Bottom=�6J   ��6e   �� *TemperatureHigh+$ 
High : {0}��6�   �� 5%   "   $��10,0,0,0q�6,   $��30��6>   $��Bottom=�6J   ��6e   �� *Percipitation+$ Percipitation : {0}��6�   5&      5'      5(      5*      5+      5,      5-      