function minimumTeachings(
  n: number,
  languages: number[][],
  friendships: number[][]
): number {
  //Language is 1-based
  // Get problematic users
  let problematicFriends = new Array<number[]>(friendships.length);

  for(let i = 0; i < friendships.length; i++) {
    let friends = friendships[i];

    let friend1Index = friends[0];
    let friend2Index = friends[1];

    let languages1 = languages[friend1Index - 1]; 
    let languages2 = languages[friend2Index - 1];

    let canTalk = false;
    for(let lang in languages1) {
      for(let lang2 in languages2) {
        if(lang == lang2) {
          canTalk = true;
          break;
        }
      }

      if(canTalk) {
        break;
      }
    }

    if(!canTalk) {
      problematicFriends.push(friends);
    }
   
  }

  let mostTalkedLang = new Map();
  for(const [fr1, fr2] of problematicFriends) {
    let lang1 = languages[fr1 - 1];
    let lang2 = languages[fr2 - 1];

    for(const lan of lang1) {
      mostTalkedLang.set(lan, )
    }
  }

  return 1;
}

let n = 3;
let languages = [[2],[1,3],[1,2],[3]];
let friendships = [[1,4],[1,2],[3,4],[2,3]];

var result = minimumTeachings(n, languages, friendships);
