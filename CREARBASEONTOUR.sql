alter table ACTIVIDADES_A_REALIZAR
   drop constraint FK_ID_ACTIVIDAD;

alter table ACTIVIDADES_A_REALIZAR
   drop constraint FK_ACTIVIDA_ACTIVIDAD_PAQUETE_;

alter table ACTIVIDADES_CURSO
   drop constraint FK_ACTIVIDA_ACTIVIDAD_CURSO;

alter table ACTIVIDADES_CURSO
   drop constraint FK_NRO_ACTIVIDAD;

alter table CONTRATO
   drop constraint FK_CONTRATO_CLIENTE_R_CURSO;

alter table CONTRATO
   drop constraint FK_CONTRATO_EJECUTIVO_EJECUTIV;

alter table CONTRATO
   drop constraint FK_CONTRATO_ESTADO_DE_ESTADO_C;

alter table CONTRATO
   drop constraint FK_CONTRATO_PAQUETE_E_PAQUETE_;

alter table CONTRATO
   drop constraint FK_CONTRATO_RELATIONS_MODALIDA;

alter table CURSO
   drop constraint FK_CURSO_COLEGIO_D_COLEGIO;

alter table CURSO
   drop constraint FK_CURSO_USUARIO_C_USUARIO;

alter table DEPOSITO
   drop constraint FK_DEPOSITO_DEPOSITO_CUENTA;

alter table DEPOSITO
   drop constraint FK_DEPOSITO_DEPOSITO2_CURSO;

alter table DETALLE_ESTADIA
   drop constraint FK_DETALLE__DETALLE_E_ESTADIA;

alter table DETALLE_ESTADIA
   drop constraint FK_DETALLE__DETALLE_E_PAQUETE_;

alter table DETALLE_VIAJES
   drop constraint FK_DETALLE__DETALLE_V_DESTINO;

alter table DETALLE_VIAJES
   drop constraint FK_DETALLE__DETALLE_V_PAQUETE_;

alter table SEGURO
   drop constraint FK_SEGURO_SERVICIO__ASEGURAD;

alter table SERVICIOS_DE_TERCEROS
   drop constraint FK_SERVICIO_BENEFICIO_BENEFICI;

alter table SERVICIOS_DE_TERCEROS
   drop constraint FK_SERVICIO_SEGUROS_C_SEGURO;

alter table SERVICIOS_DE_TERCEROS
   drop constraint FK_SERVICIO_SERVICIOS_CONTRATO;

alter table USUARIO
   drop constraint FK_USUARIO_USUARIO_C_CURSO;

drop table ACTIVIDAD cascade constraints;

drop table ACTIVIDADES cascade constraints;

drop index FK_ID_PAQUETE;

drop index FK_ID_ACTIVIDAD;

drop table ACTIVIDADES_A_REALIZAR cascade constraints;

drop index FK_ID_CURSO;

drop index FK_ACTIVIDAD_CLIENTE;

drop table ACTIVIDADES_CURSO cascade constraints;

drop table ASEGURADORA cascade constraints;

drop table BENEFICIO cascade constraints;

drop table COLEGIO cascade constraints;

drop index FK_CLIENTE_REALIZA_CONTRATO;

drop index FK_ESTADO_DEL_CONTRATO;

drop index FK_RELATIONSHIP_6;

drop index FK_PAQUETE_EN_CONTRATO;

drop index FK_EJECUTIVO_REALIZA_CONTRATO;

drop table CONTRATO cascade constraints;

drop table CUENTA cascade constraints;

drop index FK_COLEGIO_DEL_CLIENTE;

drop index FK_USUARIO_CLIENTE2;

drop table CURSO cascade constraints;

drop index FK_DEPOSITO2;

drop index FK_DEPOSITO;

drop table DEPOSITO cascade constraints;

drop table DESTINO cascade constraints;

drop index FK_ID_PAQUETE_ESTADIA;

drop index FK_ID_ESTADIA;

drop table DETALLE_ESTADIA cascade constraints;

drop index FK_DETALLE_VIAJES2;

drop index FK_DETALLE_VIAJES;

drop table DETALLE_VIAJES cascade constraints;

drop table EJECUTIVO cascade constraints;

drop table ESTADIA cascade constraints;

drop table ESTADO_CONTRATO cascade constraints;

drop table MODALIDAD_PAGO cascade constraints;

drop table PAQUETE_TURISTICO cascade constraints;

drop index FK_SERVICIO_ENTREGADO_POR;

drop table SEGURO cascade constraints;

drop index FK_BENEFICIOS_CONTRATADOS;

drop index FK_SEGUROS_CONTRATADOS;

drop index FK_NRO_CONTRATO;

drop table SERVICIOS_DE_TERCEROS cascade constraints;

drop index FK_USUARIO_CLIENTE;

drop table USUARIO cascade constraints;

/*==============================================================*/
/* Table: ACTIVIDAD                                             */
/*==============================================================*/
create table ACTIVIDAD 
(
   ID_ACTIVIDAD         NUMBER               not null,
   NOM_ACTIVIDAD        VARCHAR2(15)         not null,
   constraint PK_ACTIVIDAD primary key (ID_ACTIVIDAD)
);

/*==============================================================*/
/* Table: ACTIVIDADES                                           */
/*==============================================================*/
create table ACTIVIDADES 
(
   NRO_ACTIVIDAD        NUMBER(10)           not null,
   DESCRIPCION_ACTIVIDAD VARCHAR2(30)         not null,
   constraint PK_ACTIVIDADES primary key (NRO_ACTIVIDAD)
);

/*==============================================================*/
/* Table: ACTIVIDADES_A_REALIZAR                                */
/*==============================================================*/
create table ACTIVIDADES_A_REALIZAR 
(
   ID_ACTIVIDAD         NUMBER               not null,
   ID_PAQUETE           NUMBER(15)           not null,
   FEC_INI_ACTIVIDAD    DATE                 not null,
   FEC_TER_ACTIVIDAD    DATE                 not null,
   constraint PK_ACTIVIDADES_A_REALIZAR primary key (ID_ACTIVIDAD, ID_PAQUETE)
);

/*==============================================================*/
/* Index: FK_ID_ACTIVIDAD                                       */
/*==============================================================*/
create index FK_ID_ACTIVIDAD on ACTIVIDADES_A_REALIZAR (
   ID_ACTIVIDAD ASC
);

/*==============================================================*/
/* Index: FK_ID_PAQUETE                                         */
/*==============================================================*/
create index FK_ID_PAQUETE on ACTIVIDADES_A_REALIZAR (
   ID_PAQUETE ASC
);

/*==============================================================*/
/* Table: ACTIVIDADES_CURSO                                     */
/*==============================================================*/
create table ACTIVIDADES_CURSO 
(
   NRO_ACTIVIDAD        NUMBER(10)           not null,
   ID_CURSO             NUMBER(10)           not null,
   FEC_ACTIVIDAD        DATE                 not null,
   constraint PK_ACTIVIDADES_CURSO primary key (NRO_ACTIVIDAD, ID_CURSO)
);

/*==============================================================*/
/* Index: FK_ACTIVIDAD_CLIENTE                                  */
/*==============================================================*/
create index FK_ACTIVIDAD_CLIENTE on ACTIVIDADES_CURSO (
   NRO_ACTIVIDAD ASC
);

/*==============================================================*/
/* Index: FK_ID_CURSO                                           */
/*==============================================================*/
create index FK_ID_CURSO on ACTIVIDADES_CURSO (
   ID_CURSO ASC
);

/*==============================================================*/
/* Table: ASEGURADORA                                           */
/*==============================================================*/
create table ASEGURADORA 
(
   RUN_ASEGURADORA      VARCHAR2(10)         not null,
   RAZON_SOCIAL         VARCHAR2(30)         not null,
   constraint PK_ASEGURADORA primary key (RUN_ASEGURADORA)
);

/*==============================================================*/
/* Table: BENEFICIO                                             */
/*==============================================================*/
create table BENEFICIO 
(
   ID_BENEFICIO         NUMBER(3)            not null,
   NOM_BENEFICIO        VARCHAR2(30)         not null,
   COSTO                NUMBER(30)           not null,
   constraint PK_BENEFICIO primary key (ID_BENEFICIO)
);

/*==============================================================*/
/* Table: COLEGIO                                               */
/*==============================================================*/
create table COLEGIO 
(
   ID_COLEGIO           NUMBER(10)           not null,
   NOM_COLEGIO          VARCHAR2(30)         not null,
   constraint PK_COLEGIO primary key (ID_COLEGIO)
);

/*==============================================================*/
/* Table: CONTRATO                                              */
/*==============================================================*/
create table CONTRATO 
(
   NRO_CONTRATO         NUMBER(10)           not null,
   ID_CURSO             NUMBER(10)           not null,
   ID_ESTADO            NUMBER(10)           not null,
   ID_MODALIDAD         NUMBER(2)            not null,
   ID_EJECUTIVO         NUMBER(10)           not null,
   ID_PAQUETE           NUMBER(15)           not null,
   FEC_INI_CONTRATO     DATE                 not null,
   FEC_TERM_CONTRATO    DATE                 not null,
   FEC_VIAJE            DATE                 not null,
   CANT_PARTICIPANTES   NUMBER(4)            not null,
   CONDICIONES          VARCHAR2(300)        not null,
   constraint PK_CONTRATO primary key (NRO_CONTRATO)
);

/*==============================================================*/
/* Index: FK_EJECUTIVO_REALIZA_CONTRATO                         */
/*==============================================================*/
create index FK_EJECUTIVO_REALIZA_CONTRATO on CONTRATO (
   ID_EJECUTIVO ASC
);

/*==============================================================*/
/* Index: FK_PAQUETE_EN_CONTRATO                                */
/*==============================================================*/
create index FK_PAQUETE_EN_CONTRATO on CONTRATO (
   ID_PAQUETE ASC
);

/*==============================================================*/
/* Index: FK_RELATIONSHIP_6                                     */
/*==============================================================*/
create index FK_RELATIONSHIP_6 on CONTRATO (
   ID_MODALIDAD ASC
);

/*==============================================================*/
/* Index: FK_ESTADO_DEL_CONTRATO                                */
/*==============================================================*/
create index FK_ESTADO_DEL_CONTRATO on CONTRATO (
   ID_ESTADO ASC
);

/*==============================================================*/
/* Index: FK_CLIENTE_REALIZA_CONTRATO                           */
/*==============================================================*/
create index FK_CLIENTE_REALIZA_CONTRATO on CONTRATO (
   ID_CURSO ASC
);

/*==============================================================*/
/* Table: CUENTA                                                */
/*==============================================================*/
create table CUENTA 
(
   NRO_CUENTA           NUMBER(10)           not null,
   NRO_CEDULA_TITULAR   VARCHAR2(10)         not null,
   MONTO_AHORRADO       NUMBER(15)           not null,
   FEC_APERTURA         DATE                 not null,
   constraint PK_CUENTA primary key (NRO_CUENTA)
);

/*==============================================================*/
/* Table: CURSO                                                 */
/*==============================================================*/
create table CURSO 
(
   ID_CURSO             NUMBER(10)           not null,
   NOM_USUARIO          VARCHAR2(30),
   ID_COLEGIO           NUMBER(10)           not null,
   RUT_REPRESENTANTE    VARCHAR2(10)         not null,
   CURSO                VARCHAR2(2)          not null,
   CORREO_REPRESENTANTE VARCHAR2(45)         not null,
   CANT_ALUMNOS         NUMBER(3)            not null,
   constraint PK_CURSO primary key (ID_CURSO)
);

/*==============================================================*/
/* Index: FK_USUARIO_CLIENTE2                                   */
/*==============================================================*/
create index FK_USUARIO_CLIENTE2 on CURSO (
   NOM_USUARIO ASC
);

/*==============================================================*/
/* Index: FK_COLEGIO_DEL_CLIENTE                                */
/*==============================================================*/
create index FK_COLEGIO_DEL_CLIENTE on CURSO (
   ID_COLEGIO ASC
);

/*==============================================================*/
/* Table: DEPOSITO                                              */
/*==============================================================*/
create table DEPOSITO 
(
   NRO_CUENTA           NUMBER(10)           not null,
   ID_CURSO             NUMBER(10)           not null,
   constraint PK_DEPOSITO primary key (NRO_CUENTA, ID_CURSO)
);

/*==============================================================*/
/* Index: FK_DEPOSITO                                           */
/*==============================================================*/
create index FK_DEPOSITO on DEPOSITO (
   NRO_CUENTA ASC
);

/*==============================================================*/
/* Index: FK_DEPOSITO2                                          */
/*==============================================================*/
create index FK_DEPOSITO2 on DEPOSITO (
   ID_CURSO ASC
);

/*==============================================================*/
/* Table: DESTINO                                               */
/*==============================================================*/
create table DESTINO 
(
   ID_DESTINO           NUMBER(10)           not null,
   NOM_DESTINO          VARCHAR2(30)         not null,
   constraint PK_DESTINO primary key (ID_DESTINO)
);

/*==============================================================*/
/* Table: DETALLE_ESTADIA                                       */
/*==============================================================*/
create table DETALLE_ESTADIA 
(
   ID_ESTADIA           NUMBER(10)           not null,
   ID_PAQUETE           NUMBER(15)           not null,
   FEC_ING_ESTADIA      DATE                 not null,
   FEC_RET_ESTADIA      DATE                 not null,
   constraint PK_DETALLE_ESTADIA primary key (ID_ESTADIA, ID_PAQUETE)
);

/*==============================================================*/
/* Index: FK_ID_ESTADIA                                         */
/*==============================================================*/
create index FK_ID_ESTADIA on DETALLE_ESTADIA (
   ID_ESTADIA ASC
);

/*==============================================================*/
/* Index: FK_ID_PAQUETE_ESTADIA                                 */
/*==============================================================*/
create index FK_ID_PAQUETE_ESTADIA on DETALLE_ESTADIA (
   ID_PAQUETE ASC
);

/*==============================================================*/
/* Table: DETALLE_VIAJES                                        */
/*==============================================================*/
create table DETALLE_VIAJES 
(
   ID_DESTINO           NUMBER(10)           not null,
   ID_PAQUETE           NUMBER(15)           not null,
   FEC_INI_VIAJE        DATE                 not null,
   FEC_TER_VIAJE        DATE                 not null,
   constraint PK_DETALLE_VIAJES primary key (ID_DESTINO, ID_PAQUETE)
);

/*==============================================================*/
/* Index: FK_DETALLE_VIAJES                                     */
/*==============================================================*/
create index FK_DETALLE_VIAJES on DETALLE_VIAJES (
   ID_DESTINO ASC
);

/*==============================================================*/
/* Index: FK_DETALLE_VIAJES2                                    */
/*==============================================================*/
create index FK_DETALLE_VIAJES2 on DETALLE_VIAJES (
   ID_PAQUETE ASC
);

/*==============================================================*/
/* Table: EJECUTIVO                                             */
/*==============================================================*/
create table EJECUTIVO 
(
   ID_EJECUTIVO         NUMBER(10)           not null,
   RUT_EJECUTIVO        VARCHAR2(10)         not null,
   NOM_EJECUTIVO        VARCHAR2(45)         not null,
   APPA_EJECUTIVOR      VARCHAR2(30)         not null,
   APMA_EJECUTIVO       VARCHAR2(30)         not null,
   FEC_INGRESO          DATE                 not null,
   FEC_NACIMIENTO       DATE                 not null,
   constraint PK_EJECUTIVO primary key (ID_EJECUTIVO)
);

/*==============================================================*/
/* Table: ESTADIA                                               */
/*==============================================================*/
create table ESTADIA 
(
   ID_ESTADIA           NUMBER(10)           not null,
   NOM_ESTADIA          VARCHAR2(10)         not null,
   VALOR_ESTADIA        NUMBER(15)           not null,
   constraint PK_ESTADIA primary key (ID_ESTADIA)
);

/*==============================================================*/
/* Table: ESTADO_CONTRATO                                       */
/*==============================================================*/
create table ESTADO_CONTRATO 
(
   ID_ESTADO            NUMBER(10)           not null,
   NOM_ESTADO           VARCHAR2(15)         not null,
   constraint PK_ESTADO_CONTRATO primary key (ID_ESTADO)
);

/*==============================================================*/
/* Table: MODALIDAD_PAGO                                        */
/*==============================================================*/
create table MODALIDAD_PAGO 
(
   ID_MODALIDAD         NUMBER(2)            not null,
   NOM_MODALIDAD        VARCHAR2(30)         not null,
   constraint PK_MODALIDAD_PAGO primary key (ID_MODALIDAD)
);

/*==============================================================*/
/* Table: PAQUETE_TURISTICO                                     */
/*==============================================================*/
create table PAQUETE_TURISTICO 
(
   ID_PAQUETE           NUMBER(15)           not null,
   NOM_PAQUETE          VARCHAR2(30)         not null,
   COSTO_PAQUETE        NUMBER(15)           not null,
   constraint PK_PAQUETE_TURISTICO primary key (ID_PAQUETE)
);

/*==============================================================*/
/* Table: SEGURO                                                */
/*==============================================================*/
create table SEGURO 
(
   ID_SEGURO            NUMBER(3)            not null,
   RUN_ASEGURADORA      VARCHAR2(10)         not null,
   NOM_SEGURO           VARCHAR2(30)         not null,
   POLIZA               NUMBER(3)            not null,
   constraint PK_SEGURO primary key (ID_SEGURO)
);

/*==============================================================*/
/* Index: FK_SERVICIO_ENTREGADO_POR                             */
/*==============================================================*/
create index FK_SERVICIO_ENTREGADO_POR on SEGURO (
   RUN_ASEGURADORA ASC
);

/*==============================================================*/
/* Table: SERVICIOS_DE_TERCEROS                                 */
/*==============================================================*/
create table SERVICIOS_DE_TERCEROS 
(
   ID_SERVICIO          NUMBER(10)           not null,
   NRO_CONTRATO         NUMBER(10),
   ID_SEGURO            NUMBER(3),
   ID_BENEFICIO         NUMBER(3),
   constraint PK_SERVICIOS_DE_TERCEROS primary key (ID_SERVICIO)
);

/*==============================================================*/
/* Index: FK_NRO_CONTRATO                                       */
/*==============================================================*/
create index FK_NRO_CONTRATO on SERVICIOS_DE_TERCEROS (
   NRO_CONTRATO ASC
);

/*==============================================================*/
/* Index: FK_SEGUROS_CONTRATADOS                                */
/*==============================================================*/
create index FK_SEGUROS_CONTRATADOS on SERVICIOS_DE_TERCEROS (
   ID_SEGURO ASC
);

/*==============================================================*/
/* Index: FK_BENEFICIOS_CONTRATADOS                             */
/*==============================================================*/
create index FK_BENEFICIOS_CONTRATADOS on SERVICIOS_DE_TERCEROS (
   ID_BENEFICIO ASC
);

/*==============================================================*/
/* Table: USUARIO                                               */
/*==============================================================*/
create table USUARIO 
(
   NOM_USUARIO          VARCHAR2(30)         not null,
   ID_CURSO             NUMBER(10)           not null,
   CONTRASENA           VARCHAR2(30)         not null,
   PREG_SECRETA         VARCHAR2(30)         not null,
   RESPUESTA            VARCHAR2(30)         not null,
   TIPO                 VARCHAR2(30)         not null,
   constraint PK_USUARIO primary key (NOM_USUARIO)
);

/*==============================================================*/
/* Index: FK_USUARIO_CLIENTE                                    */
/*==============================================================*/
create index FK_USUARIO_CLIENTE on USUARIO (
   ID_CURSO ASC
);

alter table ACTIVIDADES_A_REALIZAR
   add constraint FK_ID_ACTIVIDAD foreign key (ID_ACTIVIDAD)
      references ACTIVIDAD (ID_ACTIVIDAD);

alter table ACTIVIDADES_A_REALIZAR
   add constraint FK_ACTIVIDA_ACTIVIDAD_PAQUETE_ foreign key (ID_PAQUETE)
      references PAQUETE_TURISTICO (ID_PAQUETE);

alter table ACTIVIDADES_CURSO
   add constraint FK_ACTIVIDA_ACTIVIDAD_CURSO foreign key (ID_CURSO)
      references CURSO (ID_CURSO);

alter table ACTIVIDADES_CURSO
   add constraint FK_NRO_ACTIVIDAD foreign key (NRO_ACTIVIDAD)
      references ACTIVIDADES (NRO_ACTIVIDAD);

alter table CONTRATO
   add constraint FK_CONTRATO_CLIENTE_R_CURSO foreign key (ID_CURSO)
      references CURSO (ID_CURSO);

alter table CONTRATO
   add constraint FK_CONTRATO_EJECUTIVO_EJECUTIV foreign key (ID_EJECUTIVO)
      references EJECUTIVO (ID_EJECUTIVO);

alter table CONTRATO
   add constraint FK_CONTRATO_ESTADO_DE_ESTADO_C foreign key (ID_ESTADO)
      references ESTADO_CONTRATO (ID_ESTADO);

alter table CONTRATO
   add constraint FK_CONTRATO_PAQUETE_E_PAQUETE_ foreign key (ID_PAQUETE)
      references PAQUETE_TURISTICO (ID_PAQUETE);

alter table CONTRATO
   add constraint FK_CONTRATO_RELATIONS_MODALIDA foreign key (ID_MODALIDAD)
      references MODALIDAD_PAGO (ID_MODALIDAD);

alter table CURSO
   add constraint FK_CURSO_COLEGIO_D_COLEGIO foreign key (ID_COLEGIO)
      references COLEGIO (ID_COLEGIO);

alter table CURSO
   add constraint FK_CURSO_USUARIO_C_USUARIO foreign key (NOM_USUARIO)
      references USUARIO (NOM_USUARIO);

alter table DEPOSITO
   add constraint FK_DEPOSITO_DEPOSITO_CUENTA foreign key (NRO_CUENTA)
      references CUENTA (NRO_CUENTA);

alter table DEPOSITO
   add constraint FK_DEPOSITO_DEPOSITO2_CURSO foreign key (ID_CURSO)
      references CURSO (ID_CURSO);

alter table DETALLE_ESTADIA
   add constraint FK_DETALLE__DETALLE_E_ESTADIA foreign key (ID_ESTADIA)
      references ESTADIA (ID_ESTADIA);

alter table DETALLE_ESTADIA
   add constraint FK_DETALLE__DETALLE_E_PAQUETE_ foreign key (ID_PAQUETE)
      references PAQUETE_TURISTICO (ID_PAQUETE);

alter table DETALLE_VIAJES
   add constraint FK_DETALLE__DETALLE_V_DESTINO foreign key (ID_DESTINO)
      references DESTINO (ID_DESTINO);

alter table DETALLE_VIAJES
   add constraint FK_DETALLE__DETALLE_V_PAQUETE_ foreign key (ID_PAQUETE)
      references PAQUETE_TURISTICO (ID_PAQUETE);

alter table SEGURO
   add constraint FK_SEGURO_SERVICIO__ASEGURAD foreign key (RUN_ASEGURADORA)
      references ASEGURADORA (RUN_ASEGURADORA);

alter table SERVICIOS_DE_TERCEROS
   add constraint FK_SERVICIO_BENEFICIO_BENEFICI foreign key (ID_BENEFICIO)
      references BENEFICIO (ID_BENEFICIO);

alter table SERVICIOS_DE_TERCEROS
   add constraint FK_SERVICIO_SEGUROS_C_SEGURO foreign key (ID_SEGURO)
      references SEGURO (ID_SEGURO);

alter table SERVICIOS_DE_TERCEROS
   add constraint FK_SERVICIO_SERVICIOS_CONTRATO foreign key (NRO_CONTRATO)
      references CONTRATO (NRO_CONTRATO);

alter table USUARIO
   add constraint FK_USUARIO_USUARIO_C_CURSO foreign key (ID_CURSO)
      references CURSO (ID_CURSO);
