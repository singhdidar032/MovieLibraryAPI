using MovieLibraryAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieLibraryAPI.Data
{
    public static class ModelBuilderExtensions
    {
        public static void SeedLanguageDB(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Language>().HasData(
                new Language
                {
                    Id = 1,
                    Name = "English"
                },
                new Language
                {
                    Id = 2,
                    Name = "Hindi"
                },
                new Language
                {
                    Id = 3,
                    Name = "French"
                },
                new Language
                {
                    Id = 4,
                    Name = "Spanish"
                }
            );
        }

        public static void SeedMovieDB(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    Id = 1,
                    Title= "Gladiator",
                    Director= "Ridley Scott",
                    Summary= "In AD 180, Hispano-Roman General Maximus Decimus Meridius intends to return to his home after he leads the Roman army to victory against the Germanic tribes near Vindobona on the Limes Germanicus. Emperor Marcus Aurelius tells Maximus that his own son, Commodus, is unfit to rule, and that he wishes Maximus to succeed him, as regent, to help save Rome from corruption and restore the Roman Republic. Commodus, upon hearing this, attempts to persuade his father he has the necessary virtues to inherit the throne. When Commodus realizes his father won't change his mind, he murders him." +
                    "Commodus proclaims himself the new emperor and asks Maximus for his loyalty, but Maximus refuses.Maximus is arrested by the Praetorian Guard and is told that he and his family will die.He kills his captors, although not without injury, and rides for his home near Trujillo, where he finds his home destroyed and his family murdered.Maximus buries his wife and son, then collapses from his injuries.He is found by slavers who take him to the city of Zucchabar in the Roman province of Mauretania Caesariensis, where he is sold to a gladiator trainer named Proximo." +
                    "Although reluctant at first, Maximus fights in local tournaments and befriends two other gladiators: Juba, a Numidian; and Hagen, a German.His military skills help him win matches and gain recognition from other gladiators and the crowd. Proximo reveals that he was once a gladiator who was freed by Marcus Aurelius, and advises Maximus that he must \"win the crowd\" to win his freedom. When Commodus organizes 150 days of games, Proximo takes his gladiators to fight in Rome's Colosseum." +
                    "Disguised by a masked helmet, Maximus debuts in gladiatorial combat in the Colosseum as a Carthaginian in a re-enactment of the Battle of Zama.Unexpectedly, Maximus leads his side to victory, and Commodus enters the Colosseum to offer his congratulations. He orders the disguised Maximus, as leader of the gladiators, to show himself and give his name; Maximus reveals himself and declares vengeance. Commodus is compelled by the crowd to let the gladiators live, and his guards are held back from striking them down." +
                    "Maximus's next fight is against a legendary undefeated gladiator named Tigris of Gaul. Commodus has arranged for several tigers to be set upon Maximus during the duel; Maximus, however, prevails. Commodus orders Maximus to kill Tigris, but Maximus spares his opponent's life; he is called \"Maximus the Merciful\" by the crowd.Angered at this outcome, Commodus taunts Maximus about his family's deaths, but Maximus turns and walks away." +
                    "Maximus discovers from Cicero, his ex - orderly, that his former legions remain loyal. Lucilla, Commodus's sister; Gracchus, an influential senator; and Maximus meet secretly. Maximus will escape Rome, join his soldiers, topple Commodus by force, and hand power back to the Roman Senate. Commodus learns of the plot when Lucilla's son, Lucius, innocently hints at the conspiracy. Commodus threatens Lucilla and Lucius, and has the Praetorian Guard arrest Gracchus and attack the gladiators' barracks. Proximo and his men, including Hagen, sacrifice themselves to enable Maximus to escape. Maximus is captured at the rendezvous with Cicero, where the latter is killed." +
                    "In an effort to win back the people's approval, Commodus challenges Maximus to a duel in the Colosseum. He stabs Maximus before the match to gain an advantage. Despite his injuries, Maximus disarms Commodus, whom the Praetorian Guard refuse to aid. Commodus then produces a hidden knife, which Maximus drives into Commodus's throat, killing him.Maximus succumbs to his wounds.Before he dies, he asks for political reforms, for his gladiator allies to be freed, and for Senator Gracchus to be reinstated.Maximus's friends and allies honor him as \"a soldier of Rome\", at Lucilla''s behest, and carry his body out of the arena, leaving the dead Commodus behind." +
                    "Juba visits the Colosseum at night and buries the figurines of Maximus's wife and son at the spot where he died. Juba promises to see Maximus again, \"but not yet\".",
                    LanguageId =1,
                    Genre= "Adventure"
                },
                new Movie
                {
                    Id = 2,
                    Title = "Sholay",
                    Director = "Ramesh Sippy",
                    Summary = "In the small village of Ramgarh, the retired policeman Thakur Baldev Singh summons a pair of small-time thieves that he had once arrested. Thakur feels that the duo – Veeru and Jai – would be ideal to help him capture Gabbar Singh, a dacoit wanted by the authorities for a ₹50,000[b] reward. Thakur tells them to surrender Gabbar to him, alive, for an additional ₹20,000 reward." +
                    "The two thieves thwart the dacoits sent by Gabbar to extort the villagers.Soon afterwards, Gabbar and his goons attack Ramgarh during the festival of Holi.In a tough battle," +
                    "Veeru and Jai are cornered.Though Thakur has a gun within his reach, he does not help them.Veeru and Jai fight back and the bandits flee.The two are, however," +
                    "upset at Thakur's inaction, and consider leaving the village. Thakur explains that Gabbar had killed nearly all of his family members, and had both his arms cut off a few years earlier, which is why he could not use the gun. He had concealed the dismemberment by always wearing a shawl." +
                    "Living in Ramgarh, the jovial Veeru and cynical Jai find themselves growing fond of the villagers.Veeru is attracted to Basanti, a feisty, talkative young woman who makes her living by driving a horse - cart.Jai is drawn to Radha," +
                    "Thakur's reclusive, widowed daughter-in-law, who subtly returns his affections.Skirmishes between Gabbar's gang and Jai-Veeru finally result in the capture of Veeru and Basanti by the dacoits. Jai attacks the gang, and the three are able to flee Gabbar's hideout with dacoits in pursuit.Fighting from behind a rock," +
                    "Jai and Veeru nearly run out of ammunition.Veeru, unaware that Jai was wounded in the gunfight, is forced to leave for more ammunition and also to drop Basanti at a safe place.Meanwhile, Jai, who is continuing the gunfight singlehandedly, decides to sacrifice himself by using his last bullet to ignite dynamite sticks on a bridge from close range." +
                    "Veeru returns, and Jai dies in his arms. Enraged, Veeru attacks Gabbar's den and catches the dacoit. Veeru nearly beats Gabbar to death when Thakur appears and reminds Veeru of the promise to hand over Gabbar alive. Thakur uses his spike-soled shoes to severely injure Gabbar and destroy his hands. The police then arrive and arrest Gabbar. After Jai's funeral, Veeru leaves Ramgarh and finds Basanti waiting for him on the train.Radha is left alone again.",
                    LanguageId = 1,
                    Genre = "Drama"
                }
            );
        }
    }
}
