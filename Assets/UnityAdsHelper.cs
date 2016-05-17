using UnityEngine;
using UnityEngine.Advertisements;

public class UnityAdsHelper : MonoBehaviour
{
    public GameObject RewardPanel;
    public GameObject FailedPanel;

    public void ShowRewardedAd()
    {
        if (Advertisement.IsReady("rewardedVideo"))
        {
            var options = new ShowOptions { resultCallback = HandleShowResult };
            Advertisement.Show("rewardedVideo", options);
        }
    }

    private void HandleShowResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("The ad was successfully shown.");
                MoneySystem.money += 1000;
                RewardPanel.SetActive(true);
                FailedPanel.SetActive(false);
                // YOUR CODE TO REWARD THE GAMER
                // Give coins etc.
                break;
            case ShowResult.Skipped:
                Debug.Log("The ad was skipped before reaching the end.");
                FailedPanel.SetActive(true);
                RewardPanel.SetActive(false);
                break;
            case ShowResult.Failed:
                Debug.LogError("The ad failed to be shown.");
                FailedPanel.SetActive(true);
                RewardPanel.SetActive(false);
                break;
        }
    }
}