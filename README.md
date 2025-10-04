<div class="header" align="center">  
<img alt="Space Station 14" width="880" height="300" src="https://raw.githubusercontent.com/space-wizards/asset-dump/de329a7898bb716b9d5ba9a0cd07f38e61f1ed05/github-logo.svg">  
</div>

SS14 Baseline is a special fork of [Space Station 14](https://github.com/space-wizards/space-station-14) created for fork developers.

Many developers familiar with SS14 often want to create their own version of the space station, or even more—their own game, based on the open-source RobustToolbox. There are usually two approaches to this task:
1) Hard fork. Developers completely redesign the repository to suit their needs, removing unnecessary content and cutting out entire systems. This is effective, but causes problems with merge conflicts and sometimes engine version updates if the developers are inexperienced.
2) Soft fork. Developers leave the original repository untouched, adding their content on top of SS14, hiding and filtering the original assets. This makes it easy to update by synchronizing with Upstream, but the process of filtering the original content is a fairly routine task, conceptually the same for any new project.

Baseline offers a starting point for the Soft fork approach for developing your unique project, in which all SS14 content is already safely hidden. At the same time, the repository has a minimum number of deviations from the original SS14 repository, which allows you to synchronize with Wizden updates without merge conflicts.

## How to use Baseline

To get started with Baseline, follow these instructions:

Clone this repository:

```
git clone https://github.com/TheShuEd/baseline-station-14.git
cd baseline-station-14
```
Change origin to your own empty repository
```
git remote remove origin
git remote add origin https://github.com/OWNER/PROJECT.git
git push -u origin master
```

If Baseline has not been updated for a long time, it makes sense to perform an Upstream sync:

```
git remote add upstream https://github.com/space-wizards/space-station-14.git
git fetch upstream
git checkout master
git merge upstream/master
git push origin master
```

At this point, you have a ready-made Baseline project with all filtered content.

For details on developing forks based on RobustToolbox and their assembly, please refer to the original repository:
https://github.com/space-wizards/space-station-14

## Contributing

We are happy to accept contributions from anybody. If you know how to improve Baseline to make it an even more convenient starting point for developing forks for SS14.

The project does not have its own Discord server, and all discussions can be posted in the [discussions](https://github.com/TheShuEd/baseline-station-14/discussions) tab.

## License

All code for the content repository is licensed under the [MIT license](https://github.com/space-wizards/space-station-14/blob/master/LICENSE.TXT).  

Most assets are licensed under [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) unless stated otherwise. Assets have their license and copyright specified in the metadata file. For example, see the [metadata for a crowbar](https://github.com/space-wizards/space-station-14/blob/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

> [!NOTE]
> Some assets are licensed under the non-commercial [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) or similar non-commercial licenses and will need to be removed if you wish to use this project commercially.
