from flask import Flask, request
from flask import jsonify
import pickle


def import_modelo():
    modelodt= pickle.load(open('./modelo_cancer_mama.sav', 'rb'))
    return modelodt

modelodt= import_modelo()

app= Flask(__name__)

@app.route('/modelo', methods=['POST'])
def home():
    dados_post= request.get_json()
    features= [dados_post[i] for i in ['tipo_histologico',
    'grau_histologico',
    'subtipo_tumoral',
    'ki67>14',
    'grupo_idade',
    'ja_ficou_gravida',
    'tempo_amamentacao',
    'atividade_fisica',
    'consumo_de_tabaco',
    'consumo_de_alcool',
    'menopausa',
    'grupo_idade_na_primeira_gestacao',
    'historia_familiar_de_cancer_relacionado',
    'grau_parentesco_familiar_cancer',
    'codigo_da_topografia_cid_o_1',
    'codigo_da_morfologia_de_acordo_com_o_cid_o_1',
    'classificacao_tnm_clinico_t_1',
    'classificacao_tnm_clinico_n_1',
    'classificacao_tnm_clinico_m_1',
    'lateralidade_do_tumor_1',
    'classificacao_tnm_patologico_n_1',
    'classificacao_tnm_patologico_t_1',
    'possui_metastase',
    'espalhamento_metastase',
    'risk_metastase',
    'estagio_tumor',
    'recep_progesterona_qtd',
    'recep_estrogenio_qtd',
    'ki67_qtd',
    'her2_qtd'
    ]]
    print(dados_post)
    result_pred= modelodt.predict([features])
    print(result_pred)
    return jsonify(resultdt= str(result_pred))


app.run(
    debug= True,
    port= '5000'
)