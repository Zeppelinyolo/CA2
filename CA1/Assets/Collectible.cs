using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    // Virtual function to be overridden by child classes
    public virtual void Collected(FakePlayerController player)
    {
        Debug.Log("Collectible Collected!");
    }

    // This function could be called when the player collects the item
    private void OnTriggerEnter(Collider other)
    {
        FakePlayerController player = other.GetComponent<FakePlayerController>();
        if (player != null)
        {
            Collected(player);
            Destroy(gameObject); // Remove the collectible from the scene after collection
        }
    }
}

// Child class 1: Increase Player's movement speed
public class SpeedCollectible : Collectible
{
    public float speedIncrease = 2f;

    public override void Collected(FakePlayerController player)
    {
        player.moveSpeed += speedIncrease;
        Debug.Log("Player's speed increased to: " + player.moveSpeed);
    }
}

// Child class 2: Increase Player's jump height
public class JumpCollectible : Collectible
{
    public float jumpHeightIncrease = 1f;

    public override void Collected(FakePlayerController player)
    {
        player.jumpHeight += jumpHeightIncrease;
        Debug.Log("Player's jump height increased to: " + player.jumpHeight);
    }
}
