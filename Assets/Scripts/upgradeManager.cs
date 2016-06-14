using UnityEngine;
using System.Collections;

public class upgradeManager : MonoBehaviour {

    public playerClick m_pClick;
    public UnityEngine.UI.Text itemInfo;
    public int m_cost;
    public int m_count;
    public int clickPower;
    public string m_name;
    private float _newCost;

    void Update()
    {
        itemInfo.text = m_name + "\nCost: " + m_cost + "\nPower: " + clickPower;
    }

    public void PurchaseUpgrade()
    {
        if (m_pClick.score >= m_cost)
        {
            ++m_count;
            m_pClick.score -= m_cost;
            m_pClick.scoreIncrement += clickPower;
            m_cost = (int)Mathf.Round(m_cost * 1.15f);
            _newCost = Mathf.Pow(m_cost, m_cost);
        }
    }
}
