   M S B A M L   `   `   `  ����G  CMağaza yeni, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Mağaza_yeni.sayfalarMağaza_yeni.sayfalar  5      (    "Mağaza_yeni.sayfalar.UrunlerSayfa   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      5local#clr-namespace:Mağaza_yeni.sayfalar     5        N� Title$  UrunlerSayfa��5	      .��5      � 
������� � RowDefinitions 5   
   �� 5      $	��100 �6   �� 5      $��* �6   .+�5   
   �� $��0��6   
�������$��Stretch=�65   ._�5      �� -   5         ��Name$ Siralama��5      $��32��6)   $	��200��66   $
��Left=�6B   $��Center=�6]   $��230,0,0,100q�6x   .@�5      ��  �� 
IsSelected . .��62   Varsayılan sıralama6G   �� 5      .��6    " En çok incelenene göre sırala6?   �� 5      .��6    En çok o alana göre sırala6<   �� 5      .��6    En yeniye göre sırala67   �� 5      .��6     En çok oy alana göre sırala6=   �� 5      .��6    En yeniye göre sırala67   �� 5      .��6    -+Fiyata göre sırala: Düşükten yükseğe6F   �� 5      .��6    -+Fiyata göre sırala: Yüksekten düşüğe6F   5      5      �� 5!   
   $��1��6   $��0��6$   
�������.��5"      �� $��200,0,90,100q�6   .+�5#      �� -   5         ��Name$ Urunler_Listesi��5#      ��68   �� *Urun+��5$      �� 5%      .R�5&      �� $	��350��6%   $	��350��61   ._�5'   "   �� 
������� �� Orientation$ Vertical=�6@   $	��340��6W   $	��340��6c   $��	30,30,0,0q�6p   $
��Left=�6�   $	��Top=�6�   .+�5(   &   �� $	��132��6.   
�������$��0q�6N   $��0,15,0,0q�6b   .��5)   *   �� $A��;pack://application:,,,/resimler/visne-receli-yorenizden.jpg��60   $��Center=�6u   $	��184��6�   $
��auto��6�   ��5*   *   �� 5+   .    �� 
TargetType" ��64   .�5,   2   ��  �� Property � �� �� Value
 �����6O   �� 5-   2    � �� 5.   6   �� 5/   :   	 �� 
TargetType"	 ��6J   .R�50   >   �� #��z��6E   
���   �$��0q�6�   ._�51   B   �� $��Center=�6S   $��Center=�6p   52   ?   53   ;   55   3   
 �� Triggers
 56   2   P� 57   6    P� Property �@J�IsMouseOver P� Value . . �58   :   ��  � ��
 �  ��6W   59   7   P� 5;   6    �@J�IsMouseOver . . �5<   :   ��  � ��
 �����6W   �� 5=   :    �@J�RenderTransformOrigin$ 0.5, 0.5&�6b   �� 5>   :    � z� 5?   >   �� 5@   B    �� ScaleX$	 1.2Q�6Q    �� ScaleY$	 1.2Q�6^   5D   ;   5F   7   5I   /   5K   '   �� 5M   &   $��Center=�6E   $��0,10,0,0q�6b   $
��Bold"�6t   ��6,   �� *isim+6t   �� 5N   &   $��Center=�6L   $��0,10,0,0q�6i   $��Light"�6{   ��6,   �� *stokBilgisi+6{   �� 5O   &   $
��Bold"�6F   $��Center=�6X   ��6,   �� *fiyat+6X   �� 5Q   &    ��Name$ sepeteklevisnereceli��6-   $��30��6K   $	��100��6W   $��0q�6c   .��5R   *   �� $4��.pack://application:,,,/resimler/sepeteekle.jpg��60   $
��Fill=�6h   5S   '   5T   #   5U      5V      ��5X      �� 5Y      .R�5Z      � 5[      5]      5^      5_      5c      5d      