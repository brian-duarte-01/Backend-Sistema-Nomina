--------------------------------------------------------
-- Archivo creado  - viernes-marzo-08-2024   
--------------------------------------------------------
--------------------------------------------------------
--  DDL for Table AGUINALDO
--------------------------------------------------------

  CREATE TABLE "AGUINALDO" 
   (	"ID_AGUINALDO" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"EMPLEADO" VARCHAR2(2000 BYTE), 
	"MESES" NUMBER, 
	"DIAS" NUMBER, 
	"SALARIO" NUMBER(10,2), 
	"TOTAL_AGUINALDO" NUMBER(10,2), 
	"TIPO_PAGO" VARCHAR2(2000 BYTE), 
	"ESTADO" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table BONO14
--------------------------------------------------------

  CREATE TABLE "BONO14" 
   (	"ID_BONO14" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"EMPLEADO" VARCHAR2(2000 BYTE), 
	"MESES" NUMBER, 
	"DIAS" NUMBER, 
	"SALARIO" NUMBER(10,2), 
	"TOTAL_BONO14" NUMBER(10,2), 
	"TIPO_PAGO" VARCHAR2(2000 BYTE), 
	"ESTADO" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table EMPLEADO
--------------------------------------------------------

  CREATE TABLE "EMPLEADO" 
   (	"ID_EMPLEADO" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"PRIMER_NOMBRE" VARCHAR2(2000 BYTE), 
	"SEGUNDO_NOMBRE" VARCHAR2(2000 BYTE), 
	"PRIMER_APELLIDO" VARCHAR2(2000 BYTE), 
	"SEGUNDO_APELLIDO" VARCHAR2(2000 BYTE), 
	"NIT" VARCHAR2(2000 BYTE), 
	"CALLE" VARCHAR2(2000 BYTE), 
	"AVENIDA" VARCHAR2(2000 BYTE), 
	"ZONA" VARCHAR2(2000 BYTE), 
	"TELEFONO" NUMBER, 
	"CORREO" VARCHAR2(2000 BYTE), 
	"EMPRESA" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table EMPRESA
--------------------------------------------------------

  CREATE TABLE "EMPRESA" 
   (	"ID_EMPRESA" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"NOMBRE" VARCHAR2(2000 BYTE), 
	"CALLE" VARCHAR2(2000 BYTE), 
	"AVENIDA" VARCHAR2(2000 BYTE), 
	"ZONA" VARCHAR2(2000 BYTE), 
	"TELEFONO" NUMBER, 
	"NIT" VARCHAR2(2000 BYTE), 
	"CORREO" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table INDEMIZACION
--------------------------------------------------------

  CREATE TABLE "INDEMIZACION" 
   (	"ID_INDEMIZACION" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"EMPLEADO" VARCHAR2(2000 BYTE), 
	"A�OS" NUMBER, 
	"MESES" NUMBER, 
	"DIAS" NUMBER, 
	"SALARIO" NUMBER(10,2), 
	"TOTAL_INDEMIZACION" NUMBER(10,2), 
	"TIPO_PAGO" VARCHAR2(2000 BYTE), 
	"ESTADO" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table PAGOS
--------------------------------------------------------

  CREATE TABLE "PAGOS" 
   (	"ID_PAGOS" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"EMPLEADO" VARCHAR2(2000 BYTE), 
	"SALARIO" NUMBER(10,2), 
	"BONIFICACION" NUMBER(10,2), 
	"IGSS_EMPLEADO" NUMBER(10,2), 
	"SALARIO_DEVENGADO" NUMBER(10,2), 
	"CUOTA_PATRONAL" NUMBER(10,2), 
	"TOTAL_EMPLEADO" NUMBER(10,2), 
	"TOTAL_PATRONAL" NUMBER(10,2), 
	"SALARIO_QUINCENAL" NUMBER(10,2), 
	"BONIFICACION_QUINCENAL" NUMBER(10,2), 
	"IGSS_EMPLEADO_QUINCENAL" NUMBER(10,2), 
	"SALARIO_DEVENGADO_QUINCENAL" NUMBER(10,2), 
	"IGSS_PATRONAL_QUINCENAL" NUMBER(10,2), 
	"TOTAL_EMPLEADO_QUINCENAL" NUMBER(10,2), 
	"TOTAL_PATRONAL_QUINCENAL" NUMBER(10,2), 
	"TIPO_PAGO" VARCHAR2(2000 BYTE), 
	"ESTADO" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION DEFERRED 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Table VACACIONES
--------------------------------------------------------

  CREATE TABLE "VACACIONES" 
   (	"ID_VACACIONES" NUMBER GENERATED ALWAYS AS IDENTITY MINVALUE 1 MAXVALUE 9999999999999999999999999999 INCREMENT BY 1 START WITH 1 CACHE 20 NOORDER  NOCYCLE  NOKEEP  NOSCALE , 
	"EMPLEADO" VARCHAR2(2000 BYTE), 
	"MESES" NUMBER, 
	"DIAS" NUMBER, 
	"SUELDO" NUMBER(10,2), 
	"TOTAL_VACACIONES" NUMBER(10,2), 
	"TIPO_PAGO" VARCHAR2(2000 BYTE), 
	"ESTADO" VARCHAR2(2000 BYTE)
   ) SEGMENT CREATION IMMEDIATE 
  PCTFREE 10 PCTUSED 40 INITRANS 1 MAXTRANS 255 
 NOCOMPRESS LOGGING
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
REM INSERTING into AGUINALDO
SET DEFINE OFF;
REM INSERTING into BONO14
SET DEFINE OFF;
REM INSERTING into EMPLEADO
SET DEFINE OFF;
Insert into EMPLEADO (ID_EMPLEADO,PRIMER_NOMBRE,SEGUNDO_NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO,NIT,CALLE,AVENIDA,ZONA,TELEFONO,CORREO,EMPRESA) values ('1','Brian','Luis','Marroquin','Dominguez','145451-1','8va calle','78-01','5','4554754','Hola@gmail.com','aws');
Insert into EMPLEADO (ID_EMPLEADO,PRIMER_NOMBRE,SEGUNDO_NOMBRE,PRIMER_APELLIDO,SEGUNDO_APELLIDO,NIT,CALLE,AVENIDA,ZONA,TELEFONO,CORREO,EMPRESA) values ('3','Jorge','Luis','Marroquin','Dominguez','145451-1','8va calle','78-01','5','4554754','Hola@gmail.com','aws');
REM INSERTING into EMPRESA
SET DEFINE OFF;
Insert into EMPRESA (ID_EMPRESA,NOMBRE,CALLE,AVENIDA,ZONA,TELEFONO,NIT,CORREO) values ('1','Aws','8va calle','29-20','5','6668777','478787k-8','duarte@hotmal.com');
REM INSERTING into INDEMIZACION
SET DEFINE OFF;
REM INSERTING into PAGOS
SET DEFINE OFF;
REM INSERTING into VACACIONES
SET DEFINE OFF;
Insert into VACACIONES (ID_VACACIONES,EMPLEADO,MESES,DIAS,SUELDO,TOTAL_VACACIONES,TIPO_PAGO,ESTADO) values ('1','Brian','2','45','3500,01','4500,21','cheque','pagado');
--------------------------------------------------------
--  DDL for Index SYS_C007447
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007447" ON "EMPRESA" ("ID_EMPRESA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007449
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007449" ON "EMPLEADO" ("ID_EMPLEADO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007451
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007451" ON "VACACIONES" ("ID_VACACIONES") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007453
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007453" ON "BONO14" ("ID_BONO14") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007455
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007455" ON "AGUINALDO" ("ID_AGUINALDO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007457
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007457" ON "INDEMIZACION" ("ID_INDEMIZACION") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007459
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007459" ON "PAGOS" ("ID_PAGOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007455
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007455" ON "AGUINALDO" ("ID_AGUINALDO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007453
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007453" ON "BONO14" ("ID_BONO14") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007449
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007449" ON "EMPLEADO" ("ID_EMPLEADO") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007447
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007447" ON "EMPRESA" ("ID_EMPRESA") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007457
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007457" ON "INDEMIZACION" ("ID_INDEMIZACION") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007459
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007459" ON "PAGOS" ("ID_PAGOS") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  TABLESPACE "USERS" ;
--------------------------------------------------------
--  DDL for Index SYS_C007451
--------------------------------------------------------

  CREATE UNIQUE INDEX "SYS_C007451" ON "VACACIONES" ("ID_VACACIONES") 
  PCTFREE 10 INITRANS 2 MAXTRANS 255 
  STORAGE(INITIAL 65536 NEXT 1048576 MINEXTENTS 1 MAXEXTENTS 2147483645
  PCTINCREASE 0 FREELISTS 1 FREELIST GROUPS 1
  BUFFER_POOL DEFAULT FLASH_CACHE DEFAULT CELL_FLASH_CACHE DEFAULT)
  TABLESPACE "USERS" ;
