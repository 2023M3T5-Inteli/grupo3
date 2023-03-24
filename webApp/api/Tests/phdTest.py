from requests import post
dict_json={
'tipo_histologico':2,
'grau_histologico': 1,
'subtipo_tumoral': 4,
'ki67>14': 1,
'grupo_idade': 2,
'ja_ficou_gravida': 1,
'tempo_amamentacao': 4,
'atividade_fisica': 1,
'consumo_de_tabaco': 2,
'consumo_de_alcool': 3,
'menopausa': 1,
'grupo_idade_na_primeira_gestacao': 1,
'historia_familiar_de_cancer_relacionado': 3,
'grau_parentesco_familiar_cancer': 4,
'codigo_da_topografia_cid_o_1': 8,
'codigo_da_morfologia_de_acordo_com_o_cid_o_1': 16,
'classificacao_tnm_clinico_t_1': 1,
'classificacao_tnm_clinico_n_1': 5,
'classificacao_tnm_clinico_m_1': 2,
'lateralidade_do_tumor_1': 1,
'classificacao_tnm_patologico_n_1': 3,
'classificacao_tnm_patologico_t_1': 2,
'possui_metastase': 0,
'espalhamento_metastase': 0,
'risk_metastase': 0,
'estagio_tumor': 2,
'recep_progesterona_qtd': 22,
'recep_estrogenio_qtd': 67,
'ki67_qtd': 51,
'her2_qtd': 775
}
url= 'http://127.0.0.1:5000/modelo'
r= post(url, json=dict_json)
print(r.status_code)