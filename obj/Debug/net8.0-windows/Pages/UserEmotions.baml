   M S B A M L   `   `   `  ����G  CDemoAnchiano, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:DemoAnchiano.PagesDemoAnchiano.Pages  5      %    DemoAnchiano.Pages.UserEmotions   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      2local clr-namespace:DemoAnchiano.Pages     5        N� Title$  UserEmotions��5	      .��5      � .+�5   
   � ���	#FFD6D6D6.+�5      �� -   5        $��terug��5      $
��Left=�6%   $��	10,10,0,0q�6@   $	��Top=�6S   6k   �� 5      -   5        $��
EmotieNaam��5      $
��Left=�6(   $��
138,90,0,0q�6C    �� TextWrapping$
 Wrap=�6W   $	��Top=�6l   $	��120��6�   �� 5      -   5        $��EmotieKleur��5      $
��Left=�6)   $��
263,90,0,0q�6D   $
 Wrap=�6X   $	��Top=�6l   $	��120��6�   �� 5      -   5        $��EmotieLevel��5      $
��Left=�6(   $��
388,90,0,0q�6C   $	��Top=�6W   $	��120��6o    � Minimum$ 0Q�6{    � Maximum$ 10Q�6�    � Value$ 5Q�6�    �� IsSnapToTickEnabled$
 True��6�    �� TickFrequency$ 1Q�6�   �� 5      -   5        $��Maak Emotie��5      $
��Left=�6+   $��
518,88,0,0q�6F   $	��Top=�6Z   6r   �� 5      $��Emotie toevoegen:��6   $
��Left=�60   $��9,83,0,0q�6K   $	��Top=�6]   �� 5      $��Emotie naam��6   $
��Left=�6*   $��
158,67,0,0q�6E   $	��Top=�6Y   �� 5      $��Kleur��6   $
��Left=�6$   $��
300,67,0,0q�6?   $	��Top=�6S   �� 5      $��level��6   $
��Left=�6$   $��
431,67,0,0q�6?   $	��Top=�6S   �� 5      $�� ��6   $
��Left=�6   $��
388,67,0,0q�6:   $	��Top=�6N   �� 5      -   5        $��	UsersList��5      $��	0,117,0,0q�6(   ��5      �� 5      .R�5      ��  �� Orientation$ 
Horizontal=�6%   .+�5      �� $��UserID��6(   $	��120��6N   ��66   �� *UserID+6N   �� 5      $��ID��6(   $	��120��6F   ��62   �� *ID+6F   �� 5       $��EmotionName��6(   $��50��6X   ��6;   �� *EmotionName+6X   �� 5!      $��TimeCreated��6(   $	��150��6X   ��6;   �� *TimeCreated+6X   �� 5"      $��level��6&   $	��150��6J   ��63   �� *level+6J   �� 5#      $��color��6&   $	��150��6J   ��63   �� *color+6J   �� 5%      -   5        $��Update��5%   %   $��75��66   6A   �� 5&      -   5        $��	Verwijder��5&   %   $��75��69   6D   5'      5(      5*      5-      5.      5/      