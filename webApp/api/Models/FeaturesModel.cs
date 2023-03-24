using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace predicitiveApi.Models;

public class FeaturesModel 
{
    // aqui, vai ficar um exemplo dos tipos de dados recebidos no endpoint do controller 
    [Required]
    public Dictionary<string, int> Features {get; private set;} = {
        {"tratamento", 1},
        {"atividade_fisica", 2},
        {"quantas_vezes_ficou_gravida", 3},
        {"tempo_de_amamentacao", 0},
        {"engravidou", 1},
        {"amamentou_na_primeira_gestacao", 2},
        {"idade_primeira_gestacao",1},
        {"classificacao_tnm_clinico_t", 2},
        {"classificacao_tnm_clinico_n", 3},
        {"classificacao_tnm_clinico_m", 2},
        {"grupo_estadio_clinico", 0},
        {"lateralidade_do_tumor", 1},
        {"codigo_da_topografia_cid_o", 2},
        {"indice_h_receptorde_progesterona", 1},
        {"grau_histologico", 1},
        {"receptor_progesterona_quantificacao_pct", 0},
        {"her2_por_fish", 2},
        {"receptorde_estrogenio_quantificacao_pct", 1},
        {"diagnostico_primario_tipo_histologico", 0},
        {"ki67_pct", 0},
        {"ki67_maior14pct", 1},
        {"receptor_estrogenio", 0},
        {"receptor_progesterona", 0},
        {"her2_por_ihc",1},
        {"subtipo_tumoral", 2},
        {"record_id", 1},
        {"repeat_instance", 2},
        {"Peso", 2},
        {"Altura", 1},
        {"Imc", 0},
    };



    // transformando o encoding das entradas 
    
    // precisa fazer uma estrutura parecida com o dicionário do python para pegar cad
}

