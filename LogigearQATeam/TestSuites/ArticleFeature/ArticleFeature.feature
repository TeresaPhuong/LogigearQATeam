﻿Feature: ArticleFeature

@Browser: Chorme	
Scenario: User can add new article
	Given I naviate to Joomla site: http://192.168.189.119/abyssal/administrator/
	And I enter username: phuong.thi.tran
	And I enter password: 123456
	And I click Login button
	When I click New Article button
	And I enter title: Using Branches into title textbox
	And I enter content: This tutorial is a comprehensive introduction to Git branches. into content textbox
	And I select value: Images of Category list
	And I click Save and Close button
	Then The successful message displays
	And The new article displays in Article Manage table
