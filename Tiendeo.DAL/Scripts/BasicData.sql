SET IDENTITY_INSERT [dbo].[Province] ON 
INSERT [dbo].[Province] ([Id], [Name]) VALUES (1, N'Barcelona')
INSERT [dbo].[Province] ([Id], [Name]) VALUES (2, N'Madrid')
SET IDENTITY_INSERT [dbo].[Province] OFF
GO 

SET IDENTITY_INSERT [dbo].[City] ON 
INSERT [dbo].[City] ([Id], [Name], [Latitude], [Longitude], [ProvinceId]) VALUES (1, N'Barcelona', 41.38559, 2.168745, 1)
INSERT [dbo].[City] ([Id], [Name], [Latitude], [Longitude], [ProvinceId]) VALUES (2, N'Madrid', 40.4203, -3.705774, 2)
INSERT [dbo].[City] ([Id], [Name], [Latitude], [Longitude], [ProvinceId]) VALUES (3, N'Badalona', 41.4500400, 2.2474100, 1)
SET IDENTITY_INSERT [dbo].[City] OFF
GO

SET IDENTITY_INSERT [dbo].[Enterprise] ON
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (1,'Corte El Inglés',1,'https://static0.tiendeo.com/upload_negocio/negocio_43/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (2,'Carrefour',2,'https://static0.tiendeo.com/upload_negocio/negocio_36/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (3,'Lidl',3,'https://static0.tiendeo.com/upload_negocio/negocio_110/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (4,'Alcampo',4,'https://static0.tiendeo.com/upload_negocio/negocio_32/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (5,'Mercadona',5,'https://static0.tiendeo.com/upload_negocio/negocio_31/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (6,'Hipercor',6,'https://static0.tiendeo.com/upload_negocio/negocio_54/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (7,'Dia',7,'https://static0.tiendeo.com/upload_negocio/negocio_1187/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (8,'Caprabo',8,'https://static0.tiendeo.com/upload_negocio/negocio_27/marker.png');
INSERT INTO [Enterprise](Id,Name,[Top],MarkerUrl) VALUES (9,'La Sirena',9,'https://static0.tiendeo.com/upload_negocio/negocio_44/marker.png');
SET IDENTITY_INSERT [dbo].[Enterprise] ON

--Stores
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Madrid Sur','Avenida de Pablo Neruda, 91-97',2,40.3809929,-3.663251,2,1);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Aluche','Avda. de los Poblados, 58',2,40.38641,-3.764148,2,2);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Los Ángeles','Avda. Andalucía, km. 7,1',2,40.36339,-3.69213533,2,3);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Las Glorias','C/Les Glories esq. C/ Llacunna, 155',1,41.40588,2.191681,2,4);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Market Berlín','Calle Berlín, 50-54',1,41.38361,2.14012122,2,5);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour La Maquinista','Carrer Potosí, 2',1,41.44199,2.198577,2,6);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Market Mercat del Guinardó','Carrer de Teodor Llorente, 10. Mercat del Guinardó',1,41.4192734,2.178715,2,7);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Carrefour Market Ramblas','Rambla de los Estudios, 113',1,41.383976,2.17075038,2,8);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','El Corte Inglés','Plaça de Catalunya, 14',1,41.38772,2.17113757,1,9);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','La Sirena BCN-ÀLIGA','c/de l''Àliga, 45',1,41.3749733,2.143289,9,10);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','El Corte Inglés','Av Portal de l''Àngel, 19',1,41.3858566,2.17246461,1,11);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','El Corte Inglés','Av. Meridiana, 350-358',1,41.4280663,2.18546176,1,12);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','El Corte Inglés','Av Diagonal, 617',1,41.38745,2.1280973,1,13);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','El Corte Inglés','Av Diagonal, 471',1,41.3925667,2.1463418,1,14);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Caprabo - Barcelona - Josep Tarradelles','Av. de Josep Tarradellas, 114',1,41.3896141,2.14369845,8,15);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Caprabo - Barcelona - Consell de Cent','Carrer del Consell de Cent, 301',1,41.3887444,2.16238451,8,16);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Caprabo - Barcelona - L''Illa Diagonal','Avinguda Diagonal, 545',1,41.38926,2.1338,8,17);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Caprabo - Barcelona - Passeig de Fabra I Puig','Passeig Fabra i Puig, 299',1,41.43026,2.168809,8,18);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Caprabo - Barcelona - Sicilia','Carrer de Sicília, 220',1,41.3981972,2.17817879,8,19);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Caprabo - Barcelona - St. Crist','Carrer del Sant Crist, 37',1,41.37459,2.13870859,8,20);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Mercadona RAMBLA DE POBLENOU','Rambla De Poblenou, 95',1,41.40237,2.199068,5,21);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Mercadona AVDA. ROMA','Avda. Roma, 22-30',1,41.3811,2.145611,5,22);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Alcampo Diagonal Mar','Avda. Diagonal Mar, 15. - C.C.Diagonal Mar',1,41.40923,2.21614,4,23);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Dia Market','Cl. craywinckel 20',1,41.41176,2.13888335,7,24);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Dia Market','Cl. laforja, 12-14',1,41.3999252,2.15056968,7,25);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','La Sirena BCN-ARNAU D''OMS','c/d''Arnau d''Oms, 34-36',1,41.42985,2.17755413,9,26);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Lidl','C/ Casanova 77-79',1,41.3859634,2.15775323,3,27);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Lidl','C/ Pujades, 15-17',1,41.39279,2.18837929,3,28);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Lidl','Gran Via Corts Catalanes, 721',1,41.39823,2.17951,3,29);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Lidl','C/ Bailén, 165-167',1,41.4004059,2.16568971,3,30);
INSERT INTO Establishment(Discriminator,Name,Address,CityId,Latitude,Longitude,EnterpriseId,[Top]) VALUES ('Store','Lidl','C/ Cartagena, 210',1,41.40642,2.18081,3,31);

--Services
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'GRAN VIA CORTS CATALANES, 536',1,41.38252,2.15953135);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. DE MADRID, 92',1,41.37833,2.127494);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. DE ROMA, 32-40',1,41.3814964,2.14593124);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. DE SARRIA, 150',1,41.3924561,2.13100815);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'GRAN VÍA DE LES CORTS CATALANES, 184',1,41.36718,2.13979);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'C. PUJADES, 328',1,41.4073524,2.20764327);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV ICARIA, 148',1,41.3904457,2.19630647);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV MADRID, 33',1,41.3771248,2.124676);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. REPUBLICA ARGENTINA, 79',1,41.4103432,2.14575529);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. VALLCARCA, 20',1,41.4085732,2.1491003);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'PS GRACIA, 17',1,41.38988,2.167255);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'C. ALABA, 45-47',1,41.3952675,2.19537163);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'CL TUSET , 20',1,41.39592,2.152178);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'C. ANGEL MARQUES 10 EXPL. MONTBAU',1,41.4301147,2.14228725);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'C. ANTONIO MACHADO, 4',1,41.44172,2.1634748);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'Cl Roger de Lluria, 37 8009 BARCELONA',1,41.38016,2.12851381);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'Avenida Meridiana 216',1,41.4155655,2.18699074);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'Ps Burrull, 4-8 8018 BARCELONA',1,41.40474,2.19748878);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'RONDA DE SANT PAU, 1',1,41.37533,2.16727877);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'C. ARAGO, 355',1,41.39739,2.17153978);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'PZ. URQUINAONA, 10',1,41.3807678,2.17338419);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'RAMBLA DE CATALUNYA, 36',1,41.38988,2.16529536);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'SANT ADRIA, 1-9',1,41.4339943,2.19013119);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AVDA GAUDI,69',1,41.40951,2.17408848);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. ALBUFERA, 135',2,40.3927422,-3.6584003);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. CANTABRIA, 35',2,40.458,-3.58691144);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'AV. CIUDAD DE BARCELONA, 204',2,40.4000435,-3.67280269);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',0,'CL ALCALA, 26',2,40.4180336,-3.698406);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Carrer de Santa Fe de Nou Mèxic, s/n',1,41.3935776,2.13606882);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Avda. Diagonal, 3',1,41.4106941,2.21764064);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Passeig d''Andreu Nin, s/n',1,41.43572,2.180325);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Carrer de Potosí, 2',1,41.4427452,2.200215);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Via Augusta, 12-14, Badalona, España',3,41.450737,2.24632239);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Calle Gran Vía, 41',2,40.42045,-3.706582);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Paseo de la Florida, S/N',2,40.4204178,-3.71844935);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Fuencarral, 136',2,40.43135,-3.703301);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',1,'Calle Acanto, 2',2,40.396534,-3.675543);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',3,'Avenida de Guadalajara, 2',2,40.41821,-3.62317419);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',3,'Av. Meridiana, 350-358',1,41.4280663,2.18546176);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',2,'RDA,UNIVERSITAT,23, Barcelona',1,41.38687,2.16680741);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',2,'AUSIAS MARCH, 13-17',1,41.390316,2.17428613);
INSERT INTO Establishment(Discriminator,ServiceType,Address,CityId,Latitude,Longitude) VALUES ('Service',2,'PL. CALLAO 2 - 7ª PLANTA',2,40.4199257,-3.706074);