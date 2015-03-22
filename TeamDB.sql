
DROP DATABASE TeamDB;
GO

CREATE DATABASE TeamDB;
GO

Use TeamDB;

CREATE TABLE [dbo].[Player] (
    [Fname]       VARCHAR (20) NOT NULL,
    [Minit]       VARCHAR (1)  NULL,
    [Lname]       VARCHAR (20) NOT NULL,
    [Bdate]       DATE         NULL,
    [Kit_Number]  VARCHAR (20) NOT NULL,
    [Address]     VARCHAR (50) NULL,
    [E_Mail]      VARCHAR (50) NULL,
    [Mobile]      VARCHAR (12) NULL,
    [Home_Phone]  VARCHAR (12) NULL,
    [Nationality] VARCHAR (20) NULL,
    [Weight]      FLOAT (53)   NULL,
    [Height]      FLOAT (53)   NULL,
    [Position]    VARCHAR (3)  NULL,
    PRIMARY KEY CLUSTERED ([Kit_Number] ASC)
);


	
	
CREATE TABLE [dbo].[Job] (
    [ID]          INT          NOT NULL,
    [Name]        VARCHAR (20) NOT NULL,
    [Describtion] VARCHAR (50) NULL,
    [Mngr_Job_ID] INT          NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


	
	
CREATE TABLE [dbo].[Employee] (
    [Fname]       VARCHAR (50) NOT NULL,
    [Minit]       VARCHAR (1)  NULL,
    [Lname]       VARCHAR (50) NOT NULL,
    [Bdate]       DATE         NULL,
    [ESSN]        VARCHAR (11) NOT NULL,
    [Address]     VARCHAR (50) NULL,
    [E_Mail]      VARCHAR (50) NULL,
    [Mobile]      VARCHAR (12) NULL,
    [Home_Phone]  VARCHAR (12) NULL,
    [Nationality] VARCHAR (50) NULL,
    [Job_ID]      INT          DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([ESSN] ASC),
    FOREIGN KEY ([Job_ID]) REFERENCES [dbo].[Job] ([ID]) ON DELETE SET DEFAULT
);


	
	
	
	
CREATE TABLE [dbo].[Performance] (
    [ID]                INT          NOT NULL,
    [Attacking]         INT          NOT NULL,
    [Defending]         INT          NOT NULL,
    [Finishing]         INT          NOT NULL,
    [Top_Speed]         INT          NOT NULL,
    [Acceleration]      INT          NOT NULL,
    [Goal_Keeping]      INT          NOT NULL,
    [Team_Work]         INT          NOT NULL,
    [Kick_Power]        INT          NOT NULL,
    [Measure_Date]      DATE         NOT NULL,
    [Player_Kit_Number] VARCHAR (20) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([Player_Kit_Number]) REFERENCES [dbo].[Player] ([Kit_Number]) ON DELETE CASCADE
);


	
CREATE TABLE [dbo].[Competition_Type] (
    [ID]       INT          NOT NULL,
    [Name]     VARCHAR (50) NOT NULL,
    [Com_Type] VARCHAR (10) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


	
	
CREATE TABLE [dbo].[Injury_Type] (
    [ID]          INT          NOT NULL,
    [Name]        VARCHAR (50) NOT NULL,
    [Describtion] VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


	
	
CREATE TABLE [dbo].[Competition_par_In] (
    [ID]           INT          NOT NULL,
    [Start_Date]   DATETIME     NOT NULL,
    [Close_Date]   DATETIME     NOT NULL,
    [Teams_number] INT          NOT NULL,
    [Country]      VARCHAR (20) NOT NULL,
    [Winner]       VARCHAR (20) NULL,
    [Comp_Type_ID] INT          NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([Comp_Type_ID]) REFERENCES [dbo].[Competition_Type] ([ID]) ON DELETE CASCADE
);


	
	
CREATE TABLE [dbo].[Injuries] (
    [ID]             INT          NOT NULL,
    [Player_Kit_No]  VARCHAR (20) NOT NULL,
    [Injury_Type_ID] INT          DEFAULT (NULL) NULL,
    [Doctor_ID]      VARCHAR (11) DEFAULT (NULL) NULL,
    [IsHealed]       VARCHAR (1)  NULL,
    [Inj_Date]       DATE         NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([Player_Kit_No]) REFERENCES [dbo].[Player] ([Kit_Number]) ON DELETE CASCADE,
    FOREIGN KEY ([Doctor_ID]) REFERENCES [dbo].[Employee] ([ESSN]) ON DELETE SET DEFAULT,
    FOREIGN KEY ([Injury_Type_ID]) REFERENCES [dbo].[Injury_Type] ([ID]) ON DELETE SET DEFAULT
);



CREATE TABLE [dbo].[Matches] (
    [Match_Date]   DATETIME     NOT NULL,
    [Opponent]     VARCHAR (20) NOT NULL,
    [Comp_ID]      INT          NULL,
    [Stadium]      VARCHAR (30) NULL,
    [Match_Result] VARCHAR (5)  NULL,
    PRIMARY KEY CLUSTERED ([Match_Date] ASC),
    FOREIGN KEY ([Comp_ID]) REFERENCES [dbo].[Competition_par_In] ([ID]) ON DELETE CASCADE
);


	
	
CREATE TABLE [dbo].[Training_Type] (
    [ID]          INT           NOT NULL,
    [Name]        VARCHAR (20)  NOT NULL,
    [Describtion] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


	
	
CREATE TABLE [dbo].[Training] (
    [ID]              INT          NOT NULL,
    [Training_Date]   DATETIME     NOT NULL,
    [Training_Period] FLOAT (53)   NULL,
    [Play_Ground]     VARCHAR (20) NULL,
    [Country]         VARCHAR (20) NOT NULL,
    [TrainingType]    INT          DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([TrainingType]) REFERENCES [dbo].[Training_Type] ([ID]) ON DELETE SET DEFAULT
);



CREATE TABLE [dbo].[Training_Absence] (
    [Player_ID] VARCHAR (20) DEFAULT (NULL) NULL,
    [Training_] INT          NOT NULL,
    FOREIGN KEY ([Training_]) REFERENCES [dbo].[Training] ([ID]) ON DELETE CASCADE,
    FOREIGN KEY ([Player_ID]) REFERENCES [dbo].[Player] ([Kit_Number]) ON DELETE SET DEFAULT
);


CREATE TABLE [dbo].[Companies] (
    [Company_ID]       VARCHAR (20) NOT NULL,
    [Company_Name]     VARCHAR (30) NOT NULL,
    [Type_Of_Activity] VARCHAR (50) NULL,
    [Our_Agents_Id]    VARCHAR (11) DEFAULT (NULL) NULL,
    [Address]          VARCHAR (50) NULL,
    [E_Mail]           VARCHAR (50) NULL,
    [Contact_Agent_ID] VARCHAR (11) NOT NULL,
    PRIMARY KEY CLUSTERED ([Company_ID] ASC),
    FOREIGN KEY ([Our_Agents_Id]) REFERENCES [dbo].[Employee] ([ESSN]) ON DELETE SET DEFAULT
);


		
CREATE TABLE [dbo].[Contracts] (
    [ID]               INT           NOT NULL,
    [Start_Date]       DATE          NOT NULL,
    [End_Date]         DATE          NOT NULL,
    [SecondPartyID]    VARCHAR (20)  NOT NULL,
    [SecondPartyType]  VARCHAR (10)  NOT NULL,
    [Contract_Content] VARCHAR (MAX) NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);


	
	
CREATE TABLE [dbo].[User_Login] (
    [UserName]   VARCHAR (100) NOT NULL,
    [Pass_Word]  VARCHAR (24)  NOT NULL,
    [Name__]     VARCHAR (50)  NOT NULL,
    [User__Type] VARCHAR (30)  NOT NULL,
    PRIMARY KEY CLUSTERED ([UserName] ASC)
);

CREATE TABLE [dbo].[Admin_Lookup] (
    [ID]       INT           IDENTITY (1, 1) NOT NULL,
    [UserName] VARCHAR (100) NOT NULL,
    [Activity] TEXT          NOT NULL,
    [ACt_Date] DATETIME      NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    FOREIGN KEY ([UserName]) REFERENCES [dbo].[User_Login] ([UserName]) ON DELETE CASCADE
);




INSERT INTO User_Login (UserName , Pass_Word , Name__ , User__Type) VALUES ('Team8' , '1' , 'Team8' , 'Admin');