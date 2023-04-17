CREATE DATABASE GasStation
GO
USE GasStation
GO

CREATE TABLE provider (
    id INT PRIMARY KEY NOT NULL IDENTITY(1, 1),
    name NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE fuel (
    id INT PRIMARY KEY NOT NULL IDENTITY(1, 1),
    fuel_name NVARCHAR(20) NOT NULL,
    price FLOAT NOT NULL,
    provider_id INT REFERENCES provider (id)
);
GO

CREATE TABLE accounting (
    id INT NOT NULL PRIMARY KEY IDENTITY(1, 1),
    fuel_id INT NOT NULL REFERENCES fuel (id),
    date DATE NOT NULL,
    volume_start INT NOT NULL,
    volume_sales INT NOT NULL
);
GO

INSERT [dbo].[provider] ([name]) VALUES (N'Gazpromneft-Mnpz')
INSERT [dbo].[provider] ([name]) VALUES (N'Gazprom Processing ')
INSERT [dbo].[provider] ([name]) VALUES (N'Lukoil-Ukhtaneftepererabotka')
INSERT [dbo].[provider] ([name]) VALUES (N'Knpz')
INSERT [dbo].[provider] ([name]) VALUES (N'Lukoil-Permnefteorgsintez ')
INSERT [dbo].[provider] ([name]) VALUES (N'Synthesis-Rubber ')
INSERT [dbo].[provider] ([name]) VALUES (N'Taif-Nk')
INSERT [dbo].[provider] ([name]) VALUES (N'Lukoil-Nizhegorodnefteorgsintez')
INSERT [dbo].[provider] ([name]) VALUES (N'Orsknefteorgsintez ')
INSERT [dbo].[provider] ([name]) VALUES (N'Sterlitamak Petrochemical Plant')
INSERT [dbo].[provider] ([name]) VALUES (N'Tatneft Im. V.D. Shashina')
INSERT [dbo].[provider] ([name]) VALUES (N'Lukoil-Volgogradneftepererabotka')
INSERT [dbo].[provider] ([name]) VALUES (N'Antipinsky Refinery')
INSERT [dbo].[provider] ([name]) VALUES (N'Alexandrovsky Oil Refinery')
INSERT [dbo].[provider] ([name]) VALUES (N'Itatskiy Refinery')
GO

INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 51.37, 1)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 47.67, 2)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 52.44, 3)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 46.91, 4)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 47.59, 5)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 50.52, 5)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'Gas', 20.09, 6)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 45.81, 7)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 55.13, 7)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'Gas', 21.5, 7)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 46.23, 8)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 52.48, 8)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-98', 52.75, 8)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92-K4', 50.89, 9)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92-K5', 54.63, 9)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'Gas', 19.95, 9)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'Sport Fuel', 100, 10)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'Gas', 20.19, 11)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 45.53, 12)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 54.11, 12)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-98', 62.09, 12)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 48.09, 13)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-95', 54.92, 13)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-98', 62.11, 13)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'Gas', 21.68, 14)
INSERT [dbo].[fuel] ([fuel_name], [price], [provider_id]) VALUES (N'AI-92', 47.66, 15)
GO
