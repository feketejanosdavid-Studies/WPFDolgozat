   M S B A M L   `   `   `  ����C  ?Dolgozat, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:DolgozatDolgozat  5   	       Dolgozat.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:Dolgozat     5   	     � Title$  
MainWindow��5   	   $	��550��6   $	��900��6)   
������  � AllowsTransparency$
 True��5
   	    � WindowStyle$
 None=�5   	   .��5      �� ���#272537 �� CornerRadius$ 20��6"   ._�5   
   �  � RowDefinitions 5      �� 5      $
��auto �6    60   �� 5      6"    � ColumnDefinitions 5      �� 5      $
��auto �6#   62   �� 5      6%   .+�5      �� -   5         ��Name$
 Logo��5      .+�5      �� $��School Paper��6   
�������$
��25px(�6C   $��40,20q�6S   6d   5      �� 5       �� Orientation$ Vertical=�6   $��1��60   .+�5      	� $��Task 1��6      
NavButtons#��[  6M   $
��40,0q�6q   ��6/   �� *	OpenTask1+6�   	� 5      $��Task 2��6   #��[  6M   $
��40,0q�6q   ��6/   �� *	OpenTask2+6�   	� 5       $��Task 3��6   #��[  6M   $
��40,0q�6q   ��6/   �� *	OpenTask3+6�   	� 5!      -   5         	�Name$ closeButton��5!      $��Close��63   #��[  6]   $
��40,0q�6�   6�   5"      �� 5#      $��10q�6   $��1��6)   $��1��66   ��6F   �� *CurrentView+6h   5$      5%      5&      