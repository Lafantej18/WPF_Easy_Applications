   M S B A M L   `   `   `  ����K  GKalkulator Netto, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Kalkulator_NettoKalkulator_Netto  5   	   !    Kalkulator_Netto.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Kalkulator_Netto     5   	     � Title$  
MainWindow��5   	   $��336.013��6   $��453.566��6-   .��5	      �  � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ 	BT_Oblicz��5      $��Oblicz��6$   $
��Left=�65   $��
96,117,0,0q�6P   $	��Top=�6d   $��73��6|   $��19��6�   6�   �� 5   
   -   5        $ 
BT_Wyczysc��5      $��	Wyczyść��6%   $
��Left=�67   $��213,117,0,0q�6R   $	��Top=�6g   $��75��6    J� RenderTransformOrigin$ 0.133,0.625&�6�   $��19��6�   6�   �� 5   
   $��Płaca brutto��6   $
��Left=�6'   $��	10,72,0,0q�6B   $	��Top=�6U   $��26��6m   $��74��6y   �� 5   
   $��Kalkulator pracy netto��6   $
��Left=�61   $��	10,17,0,0q�6L   $	��Top=�6_   $	��412��6w   $��30(�6�   $��50��6�   �� 5   
   -   5         ��Name$ 
TXB_Brutto��5      $
��Left=�6&   $��23��6A   $��	96,74,0,0q�6M    �� TextWrapping$
 Wrap=�6`   $	��Top=�6t   $	��120��6�   6�   �� 5   
   $��Wyniki��6   $
��Left=�6!   $��
10,162,0,0q�6<   $	��Top=�6P   $��55��6h   $��26��6s   �� 5   
   -   5        $ 
TXB_Wyniki��5      $
��Left=�6&   $	��121��6A   $��
70,162,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��274��6�   5      5      