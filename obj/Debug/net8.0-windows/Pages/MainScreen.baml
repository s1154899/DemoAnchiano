   M S B A M L   `   `   `  ����G  CDemoAnchiano, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DemoAnchiano.PagesDemoAnchiano.Pages  5      #    DemoAnchiano.Pages.MainScreen   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:DemoAnchiano.Pages     5        N� Title$  
MainScreen��5	      .��5      � ���	#FFD6D6D6.+�5   
   �� -   5        $��NaamNieuweGebruiker��5      $
��Left=�6-   $��
148,23,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6q   $	��120��6�   �� 5   
   -   5        $��LeeftijdNieuweGebruiker��5      $
��Left=�61   $��
273,23,0,0q�6L   $
 Wrap=�6`   $	��Top=�6t   $	��120��6�   �� 5   
   -   5        $��ActiefNieuweGebruiker��5      $
��Left=�61   $��
409,24,0,0q�6L   $	��Top=�6`    J� RenderTransformOrigin$ 0.432,-0.003&�6x   �� 5   
   -   5        $��Maak Gebruiker��5      $
��Left=�6*   $��
448,21,0,0q�6E   $	��Top=�6Y   6q   �� 5   
   $��Gebruiker toevoegen:��6   $
��Left=�6/   $��	19,16,0,0q�6J   $	��Top=�6]   �� 5   
   $
��Naam��6   $
��Left=�6   $��	187,0,0,0q�6:   $	��Top=�6M   �� 5   
   $��leeftijd��6   $
��Left=�6#   $��	310,0,0,0q�6>   $	��Top=�6Q   �� 5   
   $��actief��6   $
��Left=�6!   $��	398,0,0,0q�6<   $	��Top=�6O   �� 5   
   -   5        $��	UsersList��5      $��0,58,0,0q�6$   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6!   .+�5      �� $��TextBlockID��6$   $	��120��6K   ��67   �� *ID+6K   �� 5      $��TextBloXName��6"   $��50��6L   ��66   �� *Name+6L   �� 5      $��TextBloXAge��6"   $	��150��6J   ��65   �� *Age+6J   �� 5      $��TextBloXTimeSubscribed��6"   $	��150��6`   ��6@   �� *TimeSubscribed+6`   �� 5      $��TextBloXTimeIsActive��6#   $	��150��6^    d� 	IsChecked 6?   �� *
IsActive+6^   �� 5      -   5        $��Update��5   !   $��75��6E   
 � Tag 62   �� *ID+6P   �� 5       -   5        $��	Verwijder��5    !   $��75��6H    65   �� *ID+6S   �� 5!      -   5        $��Zie emoties��5!   !   $��75��6J    67   �� *ID+6U   5"      5#      5%      �� 5&   
   -	   5        $��oude Acties��5&      $
��Left=�6'   $��
724,19,0,0q�6B   $	��Top=�6V   6n   5(      5)      