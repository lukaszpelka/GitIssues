using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Globalization;

namespace IssuesManagerAbstract
{
    /// <summary>
    /// Issues are a great way to keep track of tasks, enhancements, and bugs for your projects.
    /// </summary>
    public partial class Issue
    {
        [JsonProperty("active_lock_reason")]
        public string? ActiveLockReason { get; set; }

        [JsonProperty("assignee")]
        public PurpleSimpleUser? Assignee { get; set; }

        [JsonProperty("assignees")]
        public AssigneeElement[]? Assignees { get; set; }

        /// <summary>
        /// How the author is associated with the repository.
        /// </summary>
        [JsonProperty("author_association")]
        public AuthorAssociation? AuthorAssociation { get; set; }

        /// <summary>
        /// Contents of the issue
        /// </summary>
        [JsonProperty("body")]
        public string? Body { get; set; }

        [JsonProperty("body_html", NullValueHandling = NullValueHandling.Ignore)]
        public string? BodyHtml { get; set; }

        [JsonProperty("body_text", NullValueHandling = NullValueHandling.Ignore)]
        public string? BodyText { get; set; }

        [JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }

        [JsonProperty("closed_by")]
        public FluffySimpleUser? ClosedBy { get; set; }

        [JsonProperty("comments")]
        public long? Comments { get; set; }

        [JsonProperty("comments_url")]
        public Uri? CommentsUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("draft", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Draft { get; set; }

        [JsonProperty("events_url")]
        public Uri? EventsUrl { get; set; }

        [JsonProperty("html_url")]
        public Uri? HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long? Id { get; set; }

        /// <summary>
        /// Labels to associate with this issue; pass one or more label names to replace the set of
        /// labels on this issue; send an empty array to clear all labels from the issue; note that
        /// the labels are silently dropped for users without push access to the repository
        /// </summary>
        [JsonProperty("labels")]
        public LabelElement[]? Labels { get; set; }

        [JsonProperty("labels_url")]
        public string? LabelsUrl { get; set; }

        [JsonProperty("locked")]
        public bool? Locked { get; set; }

        [JsonProperty("milestone")]
        public Milestone Milestone { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// Number uniquely identifying the issue within its repository
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("performed_via_github_app")]
        public GitHubApp PerformedViaGithubApp { get; set; }

        [JsonProperty("pull_request", NullValueHandling = NullValueHandling.Ignore)]
        public PullRequest PullRequest { get; set; }

        [JsonProperty("reactions", NullValueHandling = NullValueHandling.Ignore)]
        public ReactionRollup Reactions { get; set; }

        /// <summary>
        /// A repository on GitHub.
        /// </summary>
        [JsonProperty("repository", NullValueHandling = NullValueHandling.Ignore)]
        public Repository Repository { get; set; }

        [JsonProperty("repository_url")]
        public Uri RepositoryUrl { get; set; }

        /// <summary>
        /// State of the issue; either 'open' or 'closed'
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        /// <summary>
        /// The reason for the current state
        /// </summary>
        [JsonProperty("state_reason")]
        public StateReason? StateReason { get; set; }

        [JsonProperty("timeline_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri TimelineUrl { get; set; }

        /// <summary>
        /// Title of the issue
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// URL for the issue
        /// </summary>
        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user")]
        public TentacledSimpleUser User { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class PurpleSimpleUser
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class AssigneeElement
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class FluffySimpleUser
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    public partial class LabelClass
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("node_id", NullValueHandling = NullValueHandling.Ignore)]
        public string NodeId { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri Url { get; set; }
    }

    /// <summary>
    /// A collection of related issues and pull requests.
    /// </summary>
    public partial class Milestone
    {
        [JsonProperty("closed_at")]
        public DateTimeOffset? ClosedAt { get; set; }

        [JsonProperty("closed_issues")]
        public long ClosedIssues { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("creator")]
        public MilestoneSimpleUser Creator { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("due_on")]
        public DateTimeOffset? DueOn { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("labels_url")]
        public Uri LabelsUrl { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        /// <summary>
        /// The number of the milestone.
        /// </summary>
        [JsonProperty("number")]
        public long Number { get; set; }

        [JsonProperty("open_issues")]
        public long OpenIssues { get; set; }

        /// <summary>
        /// The state of the milestone.
        /// </summary>
        [JsonProperty("state")]
        public State State { get; set; }

        /// <summary>
        /// The title of the milestone.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class MilestoneSimpleUser
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    public partial class GitHubApp
    {
        [JsonProperty("client_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientId { get; set; }

        [JsonProperty("client_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ClientSecret { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// The list of events for the GitHub app
        /// </summary>
        [JsonProperty("events")]
        public string[] Events { get; set; }

        [JsonProperty("external_url")]
        public Uri ExternalUrl { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the GitHub app
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// The number of installations associated with the GitHub app
        /// </summary>
        [JsonProperty("installations_count", NullValueHandling = NullValueHandling.Ignore)]
        public long? InstallationsCount { get; set; }

        /// <summary>
        /// The name of the GitHub app
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("owner")]
        public PerformedViaGithubAppSimpleUser Owner { get; set; }

        [JsonProperty("pem", NullValueHandling = NullValueHandling.Ignore)]
        public string Pem { get; set; }

        /// <summary>
        /// The set of permissions for the GitHub app
        /// </summary>
        [JsonProperty("permissions")]
        public Dictionary<string, string> Permissions { get; set; }

        /// <summary>
        /// The slug name of the GitHub app
        /// </summary>
        [JsonProperty("slug", NullValueHandling = NullValueHandling.Ignore)]
        public string Slug { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("webhook_secret")]
        public string WebhookSecret { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class PerformedViaGithubAppSimpleUser
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    public partial class PullRequest
    {
        [JsonProperty("diff_url")]
        public Uri DiffUrl { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("merged_at")]
        public DateTimeOffset? MergedAt { get; set; }

        [JsonProperty("patch_url")]
        public Uri PatchUrl { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class ReactionRollup
    {
        [JsonProperty("+1")]
        public long The1 { get; set; }

        [JsonProperty("-1")]
        public long ReactionRollup1 { get; set; }

        [JsonProperty("confused")]
        public long Confused { get; set; }

        [JsonProperty("eyes")]
        public long Eyes { get; set; }

        [JsonProperty("heart")]
        public long Heart { get; set; }

        [JsonProperty("hooray")]
        public long Hooray { get; set; }

        [JsonProperty("laugh")]
        public long Laugh { get; set; }

        [JsonProperty("rocket")]
        public long Rocket { get; set; }

        [JsonProperty("total_count")]
        public long TotalCount { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    /// <summary>
    /// A repository on GitHub.
    /// </summary>
    public partial class Repository
    {
        /// <summary>
        /// Whether to allow Auto-merge to be used on pull requests.
        /// </summary>
        [JsonProperty("allow_auto_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAutoMerge { get; set; }

        /// <summary>
        /// Whether to allow forking this repo
        /// </summary>
        [JsonProperty("allow_forking", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowForking { get; set; }

        /// <summary>
        /// Whether to allow merge commits for pull requests.
        /// </summary>
        [JsonProperty("allow_merge_commit", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowMergeCommit { get; set; }

        /// <summary>
        /// Whether to allow rebase merges for pull requests.
        /// </summary>
        [JsonProperty("allow_rebase_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowRebaseMerge { get; set; }

        /// <summary>
        /// Whether to allow squash merges for pull requests.
        /// </summary>
        [JsonProperty("allow_squash_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSquashMerge { get; set; }

        /// <summary>
        /// Whether or not a pull request head branch that is behind its base branch can always be
        /// updated even if it is not required to be up to date before merging.
        /// </summary>
        [JsonProperty("allow_update_branch", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUpdateBranch { get; set; }

        /// <summary>
        /// Whether anonymous git access is enabled for this repository
        /// </summary>
        [JsonProperty("anonymous_access_enabled", NullValueHandling = NullValueHandling.Ignore)]
        public bool? AnonymousAccessEnabled { get; set; }

        [JsonProperty("archive_url")]
        public string ArchiveUrl { get; set; }

        /// <summary>
        /// Whether the repository is archived.
        /// </summary>
        [JsonProperty("archived")]
        public bool Archived { get; set; }

        [JsonProperty("assignees_url")]
        public string AssigneesUrl { get; set; }

        [JsonProperty("blobs_url")]
        public string BlobsUrl { get; set; }

        [JsonProperty("branches_url")]
        public string BranchesUrl { get; set; }

        [JsonProperty("clone_url")]
        public string CloneUrl { get; set; }

        [JsonProperty("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("compare_url")]
        public string CompareUrl { get; set; }

        [JsonProperty("contents_url")]
        public string ContentsUrl { get; set; }

        [JsonProperty("contributors_url")]
        public Uri ContributorsUrl { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        /// <summary>
        /// The default branch of the repository.
        /// </summary>
        [JsonProperty("default_branch")]
        public string DefaultBranch { get; set; }

        /// <summary>
        /// Whether to delete head branches when pull requests are merged
        /// </summary>
        [JsonProperty("delete_branch_on_merge", NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteBranchOnMerge { get; set; }

        [JsonProperty("deployments_url")]
        public Uri DeploymentsUrl { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns whether or not this repository disabled.
        /// </summary>
        [JsonProperty("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("downloads_url")]
        public Uri DownloadsUrl { get; set; }

        [JsonProperty("events_url")]
        public Uri EventsUrl { get; set; }

        [JsonProperty("fork")]
        public bool Fork { get; set; }

        [JsonProperty("forks")]
        public long Forks { get; set; }

        [JsonProperty("forks_count")]
        public long ForksCount { get; set; }

        [JsonProperty("forks_url")]
        public Uri ForksUrl { get; set; }

        [JsonProperty("full_name")]
        public string FullName { get; set; }

        [JsonProperty("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        public string GitRefsUrl { get; set; }

        [JsonProperty("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_url")]
        public string GitUrl { get; set; }

        /// <summary>
        /// Whether discussions are enabled.
        /// </summary>
        [JsonProperty("has_discussions", NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasDiscussions { get; set; }

        /// <summary>
        /// Whether downloads are enabled.
        /// </summary>
        [JsonProperty("has_downloads")]
        public bool HasDownloads { get; set; }

        /// <summary>
        /// Whether issues are enabled.
        /// </summary>
        [JsonProperty("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_pages")]
        public bool HasPages { get; set; }

        /// <summary>
        /// Whether projects are enabled.
        /// </summary>
        [JsonProperty("has_projects")]
        public bool HasProjects { get; set; }

        /// <summary>
        /// Whether the wiki is enabled.
        /// </summary>
        [JsonProperty("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("homepage")]
        public Uri Homepage { get; set; }

        [JsonProperty("hooks_url")]
        public Uri HooksUrl { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        /// <summary>
        /// Unique identifier of the repository
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Whether this repository acts as a template that can be used to generate new repositories.
        /// </summary>
        [JsonProperty("is_template", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsTemplate { get; set; }

        [JsonProperty("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("issues_url")]
        public string IssuesUrl { get; set; }

        [JsonProperty("keys_url")]
        public string KeysUrl { get; set; }

        [JsonProperty("labels_url")]
        public string LabelsUrl { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("languages_url")]
        public Uri LanguagesUrl { get; set; }

        [JsonProperty("license")]
        public LicenseSimple License { get; set; }

        [JsonProperty("master_branch", NullValueHandling = NullValueHandling.Ignore)]
        public string MasterBranch { get; set; }

        /// <summary>
        /// The default value for a merge commit message.
        ///
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `PR_BODY` - default to the pull request's body.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [JsonProperty("merge_commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public MergeCommitMessage? MergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a merge commit title.
        ///
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull
        /// request #123 from branch-name).
        /// </summary>
        [JsonProperty("merge_commit_title", NullValueHandling = NullValueHandling.Ignore)]
        public MergeCommitTitle? MergeCommitTitle { get; set; }

        [JsonProperty("merges_url")]
        public Uri MergesUrl { get; set; }

        [JsonProperty("milestones_url")]
        public string MilestonesUrl { get; set; }

        [JsonProperty("mirror_url")]
        public Uri MirrorUrl { get; set; }

        /// <summary>
        /// The name of the repository.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("notifications_url")]
        public string NotificationsUrl { get; set; }

        [JsonProperty("open_issues")]
        public long OpenIssues { get; set; }

        [JsonProperty("open_issues_count")]
        public long OpenIssuesCount { get; set; }

        /// <summary>
        /// A GitHub user.
        /// </summary>
        [JsonProperty("owner")]
        public OwnerClass Owner { get; set; }

        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public Permissions Permissions { get; set; }

        /// <summary>
        /// Whether the repository is private or public.
        /// </summary>
        [JsonProperty("private")]
        public bool Private { get; set; }

        [JsonProperty("pulls_url")]
        public string PullsUrl { get; set; }

        [JsonProperty("pushed_at")]
        public DateTimeOffset? PushedAt { get; set; }

        [JsonProperty("releases_url")]
        public string ReleasesUrl { get; set; }

        /// <summary>
        /// The size of the repository, in kilobytes. Size is calculated hourly. When a repository is
        /// initially created, the size is 0.
        /// </summary>
        [JsonProperty("size")]
        public long Size { get; set; }

        /// <summary>
        /// The default value for a squash merge commit message:
        ///
        /// - `PR_BODY` - default to the pull request's body.
        /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
        /// - `BLANK` - default to a blank commit message.
        /// </summary>
        [JsonProperty("squash_merge_commit_message", NullValueHandling = NullValueHandling.Ignore)]
        public SquashMergeCommitMessage? SquashMergeCommitMessage { get; set; }

        /// <summary>
        /// The default value for a squash merge commit title:
        ///
        /// - `PR_TITLE` - default to the pull request's title.
        /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull
        /// request's title (when more than one commit).
        /// </summary>
        [JsonProperty("squash_merge_commit_title", NullValueHandling = NullValueHandling.Ignore)]
        public SquashMergeCommitTitle? SquashMergeCommitTitle { get; set; }

        [JsonProperty("ssh_url")]
        public string SshUrl { get; set; }

        [JsonProperty("stargazers_count")]
        public long StargazersCount { get; set; }

        [JsonProperty("stargazers_url")]
        public Uri StargazersUrl { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("statuses_url")]
        public string StatusesUrl { get; set; }

        [JsonProperty("subscribers_url")]
        public Uri SubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        public Uri SubscriptionUrl { get; set; }

        [JsonProperty("svn_url")]
        public Uri SvnUrl { get; set; }

        [JsonProperty("tags_url")]
        public Uri TagsUrl { get; set; }

        [JsonProperty("teams_url")]
        public Uri TeamsUrl { get; set; }

        [JsonProperty("temp_clone_token", NullValueHandling = NullValueHandling.Ignore)]
        public string TempCloneToken { get; set; }

        [JsonProperty("topics", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Topics { get; set; }

        [JsonProperty("trees_url")]
        public string TreesUrl { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        /// <summary>
        /// Whether a squash merge commit can use the pull request title as default. **This property
        /// is closing down. Please use `squash_merge_commit_title` instead.
        /// </summary>
        [JsonProperty("use_squash_pr_title_as_default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSquashPrTitleAsDefault { get; set; }

        /// <summary>
        /// The repository visibility: public, private, or internal.
        /// </summary>
        [JsonProperty("visibility", NullValueHandling = NullValueHandling.Ignore)]
        public string Visibility { get; set; }

        [JsonProperty("watchers")]
        public long Watchers { get; set; }

        [JsonProperty("watchers_count")]
        public long WatchersCount { get; set; }

        /// <summary>
        /// Whether to require contributors to sign off on web-based commits
        /// </summary>
        [JsonProperty("web_commit_signoff_required", NullValueHandling = NullValueHandling.Ignore)]
        public bool? WebCommitSignoffRequired { get; set; }
    }

    /// <summary>
    /// License Simple
    /// </summary>
    public partial class LicenseSimple
    {
        [JsonProperty("html_url", NullValueHandling = NullValueHandling.Ignore)]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("spdx_id")]
        public string SpdxId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class OwnerClass
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    public partial class Permissions
    {
        [JsonProperty("admin")]
        public bool Admin { get; set; }

        [JsonProperty("maintain", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Maintain { get; set; }

        [JsonProperty("pull")]
        public bool Pull { get; set; }

        [JsonProperty("push")]
        public bool Push { get; set; }

        [JsonProperty("triage", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Triage { get; set; }
    }

    /// <summary>
    /// A GitHub user.
    /// </summary>
    public partial class TentacledSimpleUser
    {
        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("starred_at", NullValueHandling = NullValueHandling.Ignore)]
        public string StarredAt { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("user_view_type", NullValueHandling = NullValueHandling.Ignore)]
        public string UserViewType { get; set; }
    }

    /// <summary>
    /// How the author is associated with the repository.
    /// </summary>
    public enum AuthorAssociation { Collaborator, Contributor, FirstTimeContributor, FirstTimer, Mannequin, Member, None, Owner };

    /// <summary>
    /// The state of the milestone.
    /// </summary>
    public enum State { Closed, Open };

    /// <summary>
    /// The default value for a merge commit message.
    ///
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `PR_BODY` - default to the pull request's body.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum MergeCommitMessage { Blank, PrBody, PrTitle };

    /// <summary>
    /// The default value for a merge commit title.
    ///
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `MERGE_MESSAGE` - default to the classic title for a merge message (e.g., Merge pull
    /// request #123 from branch-name).
    /// </summary>
    public enum MergeCommitTitle { MergeMessage, PrTitle };

    /// <summary>
    /// The default value for a squash merge commit message:
    ///
    /// - `PR_BODY` - default to the pull request's body.
    /// - `COMMIT_MESSAGES` - default to the branch's commit messages.
    /// - `BLANK` - default to a blank commit message.
    /// </summary>
    public enum SquashMergeCommitMessage { Blank, CommitMessages, PrBody };

    /// <summary>
    /// The default value for a squash merge commit title:
    ///
    /// - `PR_TITLE` - default to the pull request's title.
    /// - `COMMIT_OR_PR_TITLE` - default to the commit's title (if only one commit) or the pull
    /// request's title (when more than one commit).
    /// </summary>
    public enum SquashMergeCommitTitle { CommitOrPrTitle, PrTitle };

    public enum StateReason { Completed, NotPlanned, Reopened };

    public partial struct LabelElement
    {
        public LabelClass LabelClass;
        public string String;

        public static implicit operator LabelElement(LabelClass LabelClass) => new LabelElement { LabelClass = LabelClass };
        public static implicit operator LabelElement(string String) => new LabelElement { String = String };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                AuthorAssociationConverter.Singleton,
                LabelElementConverter.Singleton,
                StateConverter.Singleton,
                MergeCommitMessageConverter.Singleton,
                MergeCommitTitleConverter.Singleton,
                SquashMergeCommitMessageConverter.Singleton,
                SquashMergeCommitTitleConverter.Singleton,
                StateReasonConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class AuthorAssociationConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(AuthorAssociation) || t == typeof(AuthorAssociation?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COLLABORATOR":
                    return AuthorAssociation.Collaborator;
                case "CONTRIBUTOR":
                    return AuthorAssociation.Contributor;
                case "FIRST_TIMER":
                    return AuthorAssociation.FirstTimer;
                case "FIRST_TIME_CONTRIBUTOR":
                    return AuthorAssociation.FirstTimeContributor;
                case "MANNEQUIN":
                    return AuthorAssociation.Mannequin;
                case "MEMBER":
                    return AuthorAssociation.Member;
                case "NONE":
                    return AuthorAssociation.None;
                case "OWNER":
                    return AuthorAssociation.Owner;
            }
            throw new Exception("Cannot unmarshal type AuthorAssociation");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (AuthorAssociation)untypedValue;
            switch (value)
            {
                case AuthorAssociation.Collaborator:
                    serializer.Serialize(writer, "COLLABORATOR");
                    return;
                case AuthorAssociation.Contributor:
                    serializer.Serialize(writer, "CONTRIBUTOR");
                    return;
                case AuthorAssociation.FirstTimer:
                    serializer.Serialize(writer, "FIRST_TIMER");
                    return;
                case AuthorAssociation.FirstTimeContributor:
                    serializer.Serialize(writer, "FIRST_TIME_CONTRIBUTOR");
                    return;
                case AuthorAssociation.Mannequin:
                    serializer.Serialize(writer, "MANNEQUIN");
                    return;
                case AuthorAssociation.Member:
                    serializer.Serialize(writer, "MEMBER");
                    return;
                case AuthorAssociation.None:
                    serializer.Serialize(writer, "NONE");
                    return;
                case AuthorAssociation.Owner:
                    serializer.Serialize(writer, "OWNER");
                    return;
            }
            throw new Exception("Cannot marshal type AuthorAssociation");
        }

        public static readonly AuthorAssociationConverter Singleton = new AuthorAssociationConverter();
    }

    internal class LabelElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelElement) || t == typeof(LabelElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    return new LabelElement { String = stringValue };
                case JsonToken.StartObject:
                    var objectValue = serializer.Deserialize<LabelClass>(reader);
                    return new LabelElement { LabelClass = objectValue };
            }
            throw new Exception("Cannot unmarshal type LabelElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (LabelElement)untypedValue;
            if (value.String != null)
            {
                serializer.Serialize(writer, value.String);
                return;
            }
            if (value.LabelClass != null)
            {
                serializer.Serialize(writer, value.LabelClass);
                return;
            }
            throw new Exception("Cannot marshal type LabelElement");
        }

        public static readonly LabelElementConverter Singleton = new LabelElementConverter();
    }

    internal class StateConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(State) || t == typeof(State?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "closed":
                    return State.Closed;
                case "open":
                    return State.Open;
            }
            throw new Exception("Cannot unmarshal type State");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (State)untypedValue;
            switch (value)
            {
                case State.Closed:
                    serializer.Serialize(writer, "closed");
                    return;
                case State.Open:
                    serializer.Serialize(writer, "open");
                    return;
            }
            throw new Exception("Cannot marshal type State");
        }

        public static readonly StateConverter Singleton = new StateConverter();
    }

    internal class MergeCommitMessageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MergeCommitMessage) || t == typeof(MergeCommitMessage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BLANK":
                    return MergeCommitMessage.Blank;
                case "PR_BODY":
                    return MergeCommitMessage.PrBody;
                case "PR_TITLE":
                    return MergeCommitMessage.PrTitle;
            }
            throw new Exception("Cannot unmarshal type MergeCommitMessage");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MergeCommitMessage)untypedValue;
            switch (value)
            {
                case MergeCommitMessage.Blank:
                    serializer.Serialize(writer, "BLANK");
                    return;
                case MergeCommitMessage.PrBody:
                    serializer.Serialize(writer, "PR_BODY");
                    return;
                case MergeCommitMessage.PrTitle:
                    serializer.Serialize(writer, "PR_TITLE");
                    return;
            }
            throw new Exception("Cannot marshal type MergeCommitMessage");
        }

        public static readonly MergeCommitMessageConverter Singleton = new MergeCommitMessageConverter();
    }

    internal class MergeCommitTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(MergeCommitTitle) || t == typeof(MergeCommitTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "MERGE_MESSAGE":
                    return MergeCommitTitle.MergeMessage;
                case "PR_TITLE":
                    return MergeCommitTitle.PrTitle;
            }
            throw new Exception("Cannot unmarshal type MergeCommitTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (MergeCommitTitle)untypedValue;
            switch (value)
            {
                case MergeCommitTitle.MergeMessage:
                    serializer.Serialize(writer, "MERGE_MESSAGE");
                    return;
                case MergeCommitTitle.PrTitle:
                    serializer.Serialize(writer, "PR_TITLE");
                    return;
            }
            throw new Exception("Cannot marshal type MergeCommitTitle");
        }

        public static readonly MergeCommitTitleConverter Singleton = new MergeCommitTitleConverter();
    }

    internal class SquashMergeCommitMessageConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SquashMergeCommitMessage) || t == typeof(SquashMergeCommitMessage?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "BLANK":
                    return SquashMergeCommitMessage.Blank;
                case "COMMIT_MESSAGES":
                    return SquashMergeCommitMessage.CommitMessages;
                case "PR_BODY":
                    return SquashMergeCommitMessage.PrBody;
            }
            throw new Exception("Cannot unmarshal type SquashMergeCommitMessage");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SquashMergeCommitMessage)untypedValue;
            switch (value)
            {
                case SquashMergeCommitMessage.Blank:
                    serializer.Serialize(writer, "BLANK");
                    return;
                case SquashMergeCommitMessage.CommitMessages:
                    serializer.Serialize(writer, "COMMIT_MESSAGES");
                    return;
                case SquashMergeCommitMessage.PrBody:
                    serializer.Serialize(writer, "PR_BODY");
                    return;
            }
            throw new Exception("Cannot marshal type SquashMergeCommitMessage");
        }

        public static readonly SquashMergeCommitMessageConverter Singleton = new SquashMergeCommitMessageConverter();
    }

    internal class SquashMergeCommitTitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(SquashMergeCommitTitle) || t == typeof(SquashMergeCommitTitle?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "COMMIT_OR_PR_TITLE":
                    return SquashMergeCommitTitle.CommitOrPrTitle;
                case "PR_TITLE":
                    return SquashMergeCommitTitle.PrTitle;
            }
            throw new Exception("Cannot unmarshal type SquashMergeCommitTitle");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (SquashMergeCommitTitle)untypedValue;
            switch (value)
            {
                case SquashMergeCommitTitle.CommitOrPrTitle:
                    serializer.Serialize(writer, "COMMIT_OR_PR_TITLE");
                    return;
                case SquashMergeCommitTitle.PrTitle:
                    serializer.Serialize(writer, "PR_TITLE");
                    return;
            }
            throw new Exception("Cannot marshal type SquashMergeCommitTitle");
        }

        public static readonly SquashMergeCommitTitleConverter Singleton = new SquashMergeCommitTitleConverter();
    }

    internal class StateReasonConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(StateReason) || t == typeof(StateReason?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "completed":
                    return StateReason.Completed;
                case "not_planned":
                    return StateReason.NotPlanned;
                case "reopened":
                    return StateReason.Reopened;
            }
            throw new Exception("Cannot unmarshal type StateReason");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (StateReason)untypedValue;
            switch (value)
            {
                case StateReason.Completed:
                    serializer.Serialize(writer, "completed");
                    return;
                case StateReason.NotPlanned:
                    serializer.Serialize(writer, "not_planned");
                    return;
                case StateReason.Reopened:
                    serializer.Serialize(writer, "reopened");
                    return;
            }
            throw new Exception("Cannot marshal type StateReason");
        }

        public static readonly StateReasonConverter Singleton = new StateReasonConverter();
    }
}
