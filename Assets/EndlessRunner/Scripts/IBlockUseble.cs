using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockUseble
{
    /// <summary>
    /// Получение объекта, отвечающего за точку создания партиклов
    /// </summary>
    /// <returns></returns>
    GameObject GetBloodGO();

    /// <summary>
    /// Получение системы частиц, анимирующей прикосновение
    /// </summary>
    /// <returns></returns>
    ParticleSystem GetBloodPS();

    void StopBleed();
}
