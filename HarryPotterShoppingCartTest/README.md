User Story
���Q�i�S�@�줭�U���饿�u�����y�A�@�ɦU�a���Ĥl�������ƨg�C
�X�������F�y��TDD�ҵ{�ۥͶ��Q�A�M�w�q�X���j���u�f�A�Ӧ^�X�����F�p�ĥ|�B�b�i�R�Ѫ������˭̡C
�w�����覡�p�U�G
1. �@�줭�������Q�i�S�A�C�@�����O��100��
2. �p�G�A�q�o�Өt�C�R�F�⥻���P���ѡA�h�|��5%���馩
3. �p�G�A�R�F�T�����P���ѡA�h�|��10%���馩
4. �p�G�O�|�����P���ѡA�h�|��20%���馩
5. �p�G�A�@���R�F��M�@�줭���A���ߧA�N�ɦ�25%���馩
6. �ݭn�d�N���O�A�p�G�A�R�F�|���ѡA�䤤�T�����P�A�ĥ|���h�O���ƪ��A
   ���򨺤T���N�ɦ�10%���馩�A�����ƪ����@���A�h����100���C
 �A�����ȬO�A�]�p�@�ӫ��Q�i�S���ʪ����A�ണ�ѳ̫K�y�����浹�o�Ǫ��������C


Feature: PotterShoppingCart
	In order to ���ѳ̫K�y�����浹�ӶR�Ѫ���������
	As a ��ߪ��X��������
	I want to �]�p�@�ӫ��Q�i�S���ʪ���

Scenario: �Ĥ@���R�F�@���A��L���S�R�A��������100*1=100��
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 0 ��
	And �ĤT���R�F 0 ��
	And �ĥ|���R�F 0 ��
	And �Ĥ����R�F 0 ��
	When ���b
	Then �������� 100 ��

Scenario: �Ĥ@���R�F�@���A�ĤG���]�R�F�@���A��������100*2*0.95=190
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 1 ��
	And �ĤT���R�F 0 ��
	And �ĥ|���R�F 0 ��
	And �Ĥ����R�F 0 ��
	When ���b
	Then �������� 190 ��

Scenario: �@�G�T���U�R�F�@���A��������100*3*0.9=270
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 1 ��
	And �ĤT���R�F 1 ��
	And �ĥ|���R�F 0 ��
	And �Ĥ����R�F 0 ��
	When ���b
	Then �������� 270 ��

Scenario: �@�G�T�|���U�R�F�@���A��������100*4*0.8=320
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 1 ��
	And �ĤT���R�F 1 ��
	And �ĥ|���R�F 1 ��
	And �Ĥ����R�F 0 ��
	When ���b
	Then �������� 320 ��

Scenario: �@���R�F��M�A�@�G�T�|�����U�R�F�@���A��������100*5*0.75=375
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 1 ��
	And �ĤT���R�F 1 ��
	And �ĥ|���R�F 1 ��
	And �Ĥ����R�F 1 ��
	When ���b
	Then �������� 375 ��

Scenario: �@�G���U�R�F�@���A�ĤT���R�F�⥻�A��������100*3*0.9 + 100 = 370
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 1 ��
	And �ĤT���R�F 2 ��
	And �ĥ|���R�F 0 ��
	And �Ĥ����R�F 0 ��
	When ���b
	Then �������� 370 ��

Scenario: �Ĥ@���R�F�@���A�ĤG�T���U�R�F�⥻�A��������100*3*0.9 + 100*2*0.95 = 460
	Given �Ĥ@���R�F 1 ��
	And �ĤG���R�F 2 ��
	And �ĤT���R�F 2 ��
	And �ĥ|���R�F 0 ��
	And �Ĥ����R�F 0 ��
	When ���b
	Then �������� 460 ��