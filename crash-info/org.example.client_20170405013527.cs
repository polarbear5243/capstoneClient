S/W Version Information
Model: SM-Z300H
Tizen-Version: 2.4.0.3
Build-Number: Z300HDDU0BPI2
Build-Date: 2016.09.30 15:37:12

Crash Information
Process Name: client
PID: 29434
Date: 2017-04-05 01:35:27+0900
Executable File Path: /opt/usr/apps/org.example.client/bin/client
Signal: 11
      (SIGSEGV)
      si_code: -6
      signal sent by tkill (sent by pid 29434, uid 5000)

Register Information
r0   = 0x000000db, r1   = 0x3f800000
r2   = 0x3f800000, r3   = 0x000000db
r4   = 0xb3fa1a3c, r5   = 0xbeeff484
r6   = 0x00000001, r7   = 0xbeeff070
r8   = 0xbeeff478, r9   = 0xb89b3d28
r10  = 0xbeeff498, fp   = 0x00000004
ip   = 0xb5fb2120, sp   = 0xbeeff050
lr   = 0xb27c42e9, pc   = 0xb27c56fe
cpsr = 0x400f0030

Memory Information
MemTotal:   987012 KB
MemFree:     58548 KB
Buffers:     53972 KB
Cached:     280536 KB
VmPeak:     103008 KB
VmSize:     103004 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       22344 KB
VmRSS:       22344 KB
VmData:      31364 KB
VmStk:         136 KB
VmExe:          20 KB
VmLib:       35748 KB
VmPTE:          76 KB
VmSwap:          0 KB

Threads Information
Threads: 4
PID = 29434 TID = 29434
29434 29439 29591 29592 

Maps Information
b104c000 b105d000 r-xp /usr/lib/scim-1.0/1.4.0/IMEngine/socket.so
b106d000 b1072000 r-xp /usr/lib/scim-1.0/1.4.0/Config/socket.so
b1370000 b1378000 r-xp /usr/lib/ecore_evas/engines/extn/v-1.13/module.so
b138a000 b1b89000 rw-p [stack:29592]
b1b89000 b1b8a000 r-xp /usr/lib/edje/modules/feedback/v-1.13/module.so
b1b9a000 b1bae000 r-xp /usr/lib/edje/modules/elm/v-1.13/module.so
b1bc2000 b1bc3000 r-xp /usr/lib/libX11-xcb.so.1.0.0
b1bd3000 b1bd6000 r-xp /usr/lib/libxcb-sync.so.1.0.0
b1be7000 b1be8000 r-xp /usr/lib/libxshmfence.so.1.0.0
b1bf8000 b1bfa000 r-xp /usr/lib/libxcb-present.so.0.0.0
b1c0a000 b1c0c000 r-xp /usr/lib/libxcb-dri3.so.0.0.0
b1c1c000 b1c2c000 r-xp /usr/lib/evas/modules/engines/software_x11/v-1.13/module.so
b1c3c000 b1c48000 r-xp /usr/lib/ecore_evas/engines/x/v-1.13/module.so
b1c5a000 b2459000 rw-p [stack:29591]
b278a000 b2791000 r-xp /usr/lib/libefl-extension.so.0.1.0
b27a4000 b27aa000 r-xp /usr/lib/bufmgr/libtbm_sprd7727.so.0.0.0
b27ba000 b27ce000 r-xp /opt/usr/apps/org.example.client/bin/client
b2926000 b2a09000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b2a40000 b2a68000 r-xp /usr/lib/ecore_imf/modules/isf/v-1.13/module.so
b2a7a000 b3279000 rw-p [stack:29439]
b3279000 b327b000 r-xp /usr/lib/ecore/system/systemd/v-1.13/module.so
b328b000 b3295000 r-xp /lib/libnss_files-2.20-2014.11.so
b32a6000 b32af000 r-xp /lib/libnss_nis-2.20-2014.11.so
b32c0000 b32d1000 r-xp /lib/libnsl-2.20-2014.11.so
b32e4000 b32ea000 r-xp /lib/libnss_compat-2.20-2014.11.so
b32fb000 b32fc000 r-xp /usr/lib/osp/libappinfo.so.1.2.2.1
b3324000 b332b000 r-xp /usr/lib/libminizip.so.1.0.0
b333b000 b3340000 r-xp /usr/lib/libstorage.so.0.1
b3350000 b33af000 r-xp /usr/lib/libmmfcamcorder.so.0.0.0
b33c5000 b33d9000 r-xp /usr/lib/libcapi-media-camera.so.0.1.90
b33e9000 b342d000 r-xp /usr/lib/libgstbase-1.0.so.0.405.0
b343d000 b3445000 r-xp /usr/lib/libgstapp-1.0.so.0.405.0
b3455000 b3485000 r-xp /usr/lib/libgstvideo-1.0.so.0.405.0
b3498000 b3551000 r-xp /usr/lib/libgstreamer-1.0.so.0.405.0
b3565000 b35b8000 r-xp /usr/lib/libmmfplayer.so.0.0.0
b35c9000 b35e4000 r-xp /usr/lib/libcapi-media-player.so.0.2.16
b35f4000 b36b5000 r-xp /usr/lib/libprotobuf.so.9.0.1
b36c8000 b36d8000 r-xp /usr/lib/libefl-assist.so.0.1.0
b36e8000 b36f5000 r-xp /usr/lib/libmdm-common.so.1.0.98
b3706000 b370d000 r-xp /usr/lib/libcapi-media-tool.so.0.2.2
b371d000 b375e000 r-xp /usr/lib/libmdm.so.1.2.12
b376e000 b3776000 r-xp /usr/lib/lib_DNSe_NRSS_ver225.so
b3785000 b3795000 r-xp /usr/lib/lib_SamsungRec_TizenV04014.so
b37b6000 b3816000 r-xp /usr/lib/libasound.so.2.0.0
b3828000 b382b000 r-xp /usr/lib/libpulse-simple.so.0.0.4
b383b000 b383e000 r-xp /usr/lib/libsyspopup_caller.so.0.1.0
b384e000 b3853000 r-xp /usr/lib/libmmfsoundcommon.so.0.0.0
b3863000 b3864000 r-xp /usr/lib/libgthread-2.0.so.0.4301.0
b3874000 b387f000 r-xp /usr/lib/libaudio-session-mgr.so.0.0.1
b3893000 b389a000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b38aa000 b38b0000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b38c0000 b38c5000 r-xp /usr/lib/libmmfsession.so.0.0.1
b38d5000 b38f0000 r-xp /usr/lib/libmmfsound.so.0.1.0
b3900000 b3907000 r-xp /usr/lib/libmmfcommon.so.0.0.0
b3917000 b391a000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.10
b392b000 b3959000 r-xp /usr/lib/libidn.so.11.5.44
b3969000 b397f000 r-xp /usr/lib/libnghttp2.so.5.4.0
b3990000 b399a000 r-xp /usr/lib/libcares.so.2.1.0
b39aa000 b39b4000 r-xp /usr/lib/libcapi-media-sound-manager.so.0.3.32
b39c4000 b39c6000 r-xp /usr/lib/libcapi-media-wav-player.so.0.1.18
b39d6000 b39d7000 r-xp /usr/lib/libmmfkeysound.so.0.0.0
b39e7000 b39eb000 r-xp /usr/lib/libecore_ipc.so.1.13.0
b39fc000 b3a24000 r-xp /usr/lib/libui-extension.so.0.1.0
b3a35000 b3a5e000 r-xp /usr/lib/libturbojpeg.so
b3a7e000 b3a84000 r-xp /usr/lib/libgif.so.4.1.6
b3a94000 b3ada000 r-xp /usr/lib/libcurl.so.4.3.0
b3aeb000 b3b0c000 r-xp /usr/lib/libexif.so.12.3.3
b3b27000 b3b3c000 r-xp /usr/lib/libtts.so
b3b4d000 b3b55000 r-xp /usr/lib/libfeedback.so.0.1.4
b3b65000 b3c2b000 r-xp /usr/lib/libdali-core.so.0.0.0
b3c4b000 b3d43000 r-xp /usr/lib/libdali-adaptor.so.0.0.0
b3d62000 b3e30000 r-xp /usr/lib/libdali-toolkit.so.0.0.0
b3e47000 b3e49000 r-xp /usr/lib/libboost_system.so.1.51.0
b3e59000 b3e5f000 r-xp /usr/lib/libboost_chrono.so.1.51.0
b3e6f000 b3e92000 r-xp /usr/lib/libboost_thread.so.1.51.0
b3ea3000 b3ea5000 r-xp /usr/lib/libappsvc.so.0.1.0
b3eb5000 b3eb7000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b3ec8000 b3ecd000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b3ee4000 b3ee6000 r-xp /usr/lib/libosp-env-config.so.1.2.2.1
b3ef6000 b3efd000 r-xp /usr/lib/libsensord-share.so
b3f0d000 b3f25000 r-xp /usr/lib/libsensor.so.1.1.0
b3f36000 b3f39000 r-xp /usr/lib/libXv.so.1.0.0
b3f49000 b3f4e000 r-xp /usr/lib/libutilX.so.1.1.0
b3f5e000 b3f63000 r-xp /usr/lib/libappcore-common.so.1.1
b3f73000 b3f7a000 r-xp /usr/lib/libcapi-ui-efl-util.so.0.2.11
b3f8d000 b3f91000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b3fa2000 b4080000 r-xp /usr/lib/libCOREGL.so.4.0
b40a0000 b40a3000 r-xp /usr/lib/libuuid.so.1.3.0
b40b3000 b40ca000 r-xp /usr/lib/libblkid.so.1.1.0
b40db000 b40dd000 r-xp /usr/lib/libXau.so.6.0.0
b40ed000 b4134000 r-xp /usr/lib/pulseaudio/libpulsecommon-4.0.so
b4146000 b414c000 r-xp /usr/lib/libjson-c.so.2.0.1
b415d000 b4161000 r-xp /usr/lib/libogg.so.0.7.1
b4171000 b4193000 r-xp /usr/lib/libvorbis.so.0.4.3
b41a3000 b4287000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b42a3000 b42a6000 r-xp /usr/lib/libEGL.so.1.4
b42b7000 b42bd000 r-xp /usr/lib/libxcb-render.so.0.0.0
b42cd000 b42cf000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b42df000 b42ec000 r-xp /usr/lib/libGLESv2.so.2.0
b42fd000 b435f000 r-xp /usr/lib/libpixman-1.so.0.28.2
b4374000 b438c000 r-xp /usr/lib/libmount.so.1.1.0
b439e000 b43b2000 r-xp /usr/lib/libxcb.so.1.1.0
b43c2000 b43c9000 r-xp /lib/libcrypt-2.20-2014.11.so
b4401000 b4403000 r-xp /usr/lib/libiri.so
b4413000 b441e000 r-xp /usr/lib/libgpg-error.so.0.15.0
b442f000 b4465000 r-xp /usr/lib/libpulse.so.0.16.2
b4476000 b44b9000 r-xp /usr/lib/libsndfile.so.1.0.25
b44ce000 b44e3000 r-xp /lib/libexpat.so.1.5.2
b44f5000 b45b3000 r-xp /usr/lib/libcairo.so.2.11200.14
b45c7000 b45cf000 r-xp /usr/lib/libdrm.so.2.4.0
b45df000 b45e2000 r-xp /usr/lib/libdri2.so.0.0.0
b45f2000 b4640000 r-xp /usr/lib/libssl.so.1.0.0
b4655000 b4661000 r-xp /usr/lib/libeeze.so.1.13.0
b4672000 b467b000 r-xp /usr/lib/libethumb.so.1.13.0
b468b000 b468e000 r-xp /usr/lib/libecore_input_evas.so.1.13.0
b469e000 b4855000 r-xp /usr/lib/libcrypto.so.1.0.0
b5640000 b5649000 r-xp /usr/lib/libXi.so.6.1.0
b5659000 b565b000 r-xp /usr/lib/libXgesture.so.7.0.0
b566b000 b566f000 r-xp /usr/lib/libXtst.so.6.1.0
b567f000 b5685000 r-xp /usr/lib/libXrender.so.1.3.0
b5695000 b569b000 r-xp /usr/lib/libXrandr.so.2.2.0
b56ab000 b56ad000 r-xp /usr/lib/libXinerama.so.1.0.0
b56be000 b56c1000 r-xp /usr/lib/libXfixes.so.3.1.0
b56d1000 b56dc000 r-xp /usr/lib/libXext.so.6.4.0
b56ec000 b56ee000 r-xp /usr/lib/libXdamage.so.1.1.0
b56fe000 b5700000 r-xp /usr/lib/libXcomposite.so.1.0.0
b5710000 b57f2000 r-xp /usr/lib/libX11.so.6.3.0
b5806000 b580d000 r-xp /usr/lib/libXcursor.so.1.0.2
b581d000 b5835000 r-xp /usr/lib/libudev.so.1.6.0
b5837000 b583a000 r-xp /lib/libattr.so.1.1.0
b584a000 b586a000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b586b000 b5870000 r-xp /usr/lib/libffi.so.6.0.2
b5881000 b5899000 r-xp /lib/libz.so.1.2.8
b58a9000 b58ab000 r-xp /usr/lib/libgmodule-2.0.so.0.4301.0
b58bb000 b5990000 r-xp /usr/lib/libxml2.so.2.9.2
b59a5000 b5a40000 r-xp /usr/lib/libstdc++.so.6.0.20
b5a5c000 b5a5f000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b5a6f000 b5a88000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b5a99000 b5aaa000 r-xp /lib/libresolv-2.20-2014.11.so
b5abe000 b5b38000 r-xp /usr/lib/libgcrypt.so.20.0.3
b5b4d000 b5b4f000 r-xp /usr/lib/libecore_imf_evas.so.1.13.0
b5b5f000 b5b66000 r-xp /usr/lib/libembryo.so.1.13.0
b5b76000 b5b80000 r-xp /usr/lib/libecore_audio.so.1.13.0
b5b91000 b5ba9000 r-xp /usr/lib/libpng12.so.0.50.0
b5bba000 b5bdd000 r-xp /usr/lib/libjpeg.so.8.0.2
b5bfe000 b5c12000 r-xp /usr/lib/libector.so.1.13.0
b5c23000 b5c3b000 r-xp /usr/lib/liblua-5.1.so
b5c4c000 b5ca3000 r-xp /usr/lib/libfreetype.so.6.11.3
b5cb7000 b5cdf000 r-xp /usr/lib/libfontconfig.so.1.8.0
b5cf0000 b5d03000 r-xp /usr/lib/libfribidi.so.0.3.1
b5d14000 b5d4e000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b5d5f000 b5d6d000 r-xp /usr/lib/libgraphics-extension.so.0.1.0
b5d7d000 b5d85000 r-xp /usr/lib/libtbm.so.1.0.0
b5d95000 b5da2000 r-xp /usr/lib/libeio.so.1.13.0
b5db2000 b5db4000 r-xp /usr/lib/libefreet_trash.so.1.13.0
b5dc4000 b5dc9000 r-xp /usr/lib/libefreet_mime.so.1.13.0
b5dd9000 b5df0000 r-xp /usr/lib/libefreet.so.1.13.0
b5e02000 b5e22000 r-xp /usr/lib/libeldbus.so.1.13.0
b5e32000 b5e52000 r-xp /usr/lib/libecore_con.so.1.13.0
b5e54000 b5e5a000 r-xp /usr/lib/libecore_imf.so.1.13.0
b5e6a000 b5e7b000 r-xp /usr/lib/libemotion.so.1.13.0
b5e8c000 b5e93000 r-xp /usr/lib/libethumb_client.so.1.13.0
b5ea3000 b5eb2000 r-xp /usr/lib/libeo.so.1.13.0
b5ec3000 b5ed5000 r-xp /usr/lib/libecore_input.so.1.13.0
b5ee6000 b5eeb000 r-xp /usr/lib/libecore_file.so.1.13.0
b5efb000 b5f14000 r-xp /usr/lib/libecore_evas.so.1.13.0
b5f24000 b5f41000 r-xp /usr/lib/libeet.so.1.13.0
b5f5a000 b5fa2000 r-xp /usr/lib/libeina.so.1.13.0
b5fb3000 b5fc3000 r-xp /usr/lib/libefl.so.1.13.0
b5fd4000 b60b9000 r-xp /usr/lib/libicuuc.so.51.1
b60d6000 b6216000 r-xp /usr/lib/libicui18n.so.51.1
b622d000 b6265000 r-xp /usr/lib/libecore_x.so.1.13.0
b6277000 b627a000 r-xp /lib/libcap.so.2.21
b628a000 b62b3000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b62c4000 b62cb000 r-xp /usr/lib/libcapi-base-common.so.0.2.2
b62dd000 b6314000 r-xp /usr/lib/libgobject-2.0.so.0.4301.0
b6325000 b6410000 r-xp /usr/lib/libgio-2.0.so.0.4301.0
b6423000 b649c000 r-xp /usr/lib/libsqlite3.so.0.8.6
b64ae000 b64b3000 r-xp /usr/lib/libcapi-system-info.so.0.2.1
b64c3000 b64cd000 r-xp /usr/lib/libvconf.so.0.2.45
b64dd000 b64df000 r-xp /usr/lib/libvasum.so.0.3.1
b64ef000 b64f1000 r-xp /usr/lib/libttrace.so.1.1
b6501000 b6504000 r-xp /usr/lib/libiniparser.so.0
b6514000 b653a000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b654a000 b654f000 r-xp /usr/lib/libxdgmime.so.1.1.0
b6560000 b6577000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b6588000 b65f3000 r-xp /lib/libm-2.20-2014.11.so
b6604000 b660a000 r-xp /lib/librt-2.20-2014.11.so
b661b000 b6628000 r-xp /usr/lib/libunwind.so.8.0.1
b665e000 b6782000 r-xp /lib/libc-2.20-2014.11.so
b6797000 b67b0000 r-xp /lib/libgcc_s-4.9.so.1
b67c0000 b68a2000 r-xp /usr/lib/libglib-2.0.so.0.4301.0
b68b3000 b68dd000 r-xp /usr/lib/libdbus-1.so.3.8.12
b68ee000 b692a000 r-xp /usr/lib/libsystemd.so.0.4.0
b692c000 b69af000 r-xp /usr/lib/libedje.so.1.13.0
b69c2000 b69e0000 r-xp /usr/lib/libecore.so.1.13.0
b6a00000 b6b87000 r-xp /usr/lib/libevas.so.1.13.0
b6bbc000 b6bd0000 r-xp /lib/libpthread-2.20-2014.11.so
b6be4000 b6e18000 r-xp /usr/lib/libelementary.so.1.13.0
b6e47000 b6e4b000 r-xp /usr/lib/libsmack.so.1.0.0
b6e5b000 b6e62000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b6e72000 b6e74000 r-xp /usr/lib/libdlog.so.0.0.0
b6e84000 b6e87000 r-xp /usr/lib/libbundle.so.0.1.22
b6e97000 b6e99000 r-xp /lib/libdl-2.20-2014.11.so
b6eaa000 b6ec2000 r-xp /usr/lib/libaul.so.0.1.0
b6ed6000 b6edb000 r-xp /usr/lib/libappcore-efl.so.1.1
b6eec000 b6ef9000 r-xp /usr/lib/liblptcp.so
b6f0b000 b6f0f000 r-xp /usr/lib/libsys-assert.so
b6f20000 b6f40000 r-xp /lib/ld-2.20-2014.11.so
b6f51000 b6f56000 r-xp /usr/bin/launchpad-loader
b894c000 b8c8a000 rw-p [heap]
beedf000 bef00000 rw-p [stack]
End of Maps Information

Callstack Information (PID:29434)
Call Stack Count: 15
 0: _ZN7RootObj13setWeightHintEff + 0x17 (0xb27c56fe) [/opt/usr/apps/org.example.client/bin/client] + 0xb6fe
 1: _ZN10MyFoodView6drawUIEP9Naviframe + 0x2ac (0xb27c42e9) [/opt/usr/apps/org.example.client/bin/client] + 0xa2e9
 2: _ZN10MyFoodViewC2EP9Naviframe + 0x58 (0xb27bfc1d) [/opt/usr/apps/org.example.client/bin/client] + 0x5c1d
 3: _ZN7MyLoginC2EP9Naviframe + 0xce (0xb27be523) [/opt/usr/apps/org.example.client/bin/client] + 0x4523
 4: _ZN8MyWindow8onCreateEv + 0x110 (0xb27be2ad) [/opt/usr/apps/org.example.client/bin/client] + 0x42ad
 5: _ZN6Window10app_createEPv + 0x72 (0xb27c5987) [/opt/usr/apps/org.example.client/bin/client] + 0xb987
 6: _ZN6Window17static_app_createEPv + 0x24 (0xb27c5afd) [/opt/usr/apps/org.example.client/bin/client] + 0xbafd
 7: (0xb3f8f4f9) [/usr/lib/libcapi-appfw-application.so.0] + 0x24f9
 8: appcore_efl_main + 0x152 (0xb6ed9203) [/usr/lib/libappcore-efl.so.1] + 0x3203
 9: ui_app_main + 0xc0 (0xb3f8f909) [/usr/lib/libcapi-appfw-application.so.0] + 0x2909
10: _ZN6Window10makeWindowEiPPc + 0x11e (0xb27c5e87) [/opt/usr/apps/org.example.client/bin/client] + 0xbe87
11: main + 0x40 (0xb27be035) [/opt/usr/apps/org.example.client/bin/client] + 0x4035
12: (0xb6f52bb5) [/opt/usr/apps/org.example.client/bin/client] + 0x1bb5
13: __libc_start_main + 0x114 (0xb66744bc) [/lib/libc.so.6] + 0x164bc
14: (0xb6f52eb4) [/opt/usr/apps/org.example.client/bin/client] + 0x1eb4
End of Call Stack

Package Information
Package Name: org.example.client
Package ID : org.example.client
Version: 1.0.0
Package Type: tpk
App Name: client
App ID: org.example.client
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
 > __request_handler: 15
04-05 01:35:14.702+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-05 01:35:14.702+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-05 01:35:14.712+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-05 01:35:14.722+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.722+0900 E/RUA     (21855): rua.c: rua_history_load_db(278) > rua_history_load_db ok. nrows : 18, ncols : 5
04-05 01:35:14.722+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.homescreen) in ai_tbl !!
04-05 01:35:14.732+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:35:14.732+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.732+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-05 01:35:14.732+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-agent) in ai_tbl !!
04-05 01:35:14.732+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.image-viewer-subapp-single) in ai_tbl !!
04-05 01:35:14.742+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:35:14.742+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10498
04-05 01:35:14.742+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-05 01:35:14.742+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.task-mgr) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.tizenstoreservice) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (org.tizen.poweroff-syspopup) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (live-com.samsung.browser) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.weather-m-widget) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (net.netpopup) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.special-day-app) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.wallpaper-ui-service) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.quickpanel) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.volume) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.lockscreen) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.pwlock) in ai_tbl !!
04-05 01:35:14.742+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_retrieve_item(263) > Can't find app (com.samsung.clock-alarm-service) in ai_tbl !!
04-05 01:35:14.752+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.772+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.792+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.802+0900 I/APP_CORE(21855): appcore-efl.c: __do_app(514) > [APP 21855] Event: RESET State: CREATED
04-05 01:35:14.802+0900 I/CAPI_APPFW_APPLICATION(21855): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-05 01:35:14.802+0900 E/EFL     (21855): edje<21855> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:14.802+0900 E/EFL     (21855): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:14.802+0900 E/EFL     (21855): edje<21855> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:14.802+0900 E/EFL     (21855): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:14.802+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.802+0900 W/APP_CORE(21855): appcore-efl.c: __show_cb(920) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:7800003
04-05 01:35:14.802+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 35
04-05 01:35:14.822+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.842+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.852+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.872+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.892+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:14.992+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(21855) status(0)
04-05 01:35:14.992+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(21855) status(0)
04-05 01:35:14.992+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: PAUSE State: RUNNING
04-05 01:35:14.992+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-05 01:35:14.992+0900 E/cluster-home(  858): homescreen.cpp: OnPause(260) >  app pause
04-05 01:35:14.992+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(4)
04-05 01:35:14.992+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.homescreen(858)
04-05 01:35:14.992+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: bg
04-05 01:35:15.002+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(21855) status(3)
04-05 01:35:15.002+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:35:15.002+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-05 01:35:15.002+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.task-mgr(21855)
04-05 01:35:15.002+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 21855, appid: com.samsung.task-mgr, status: fg
04-05 01:35:15.002+0900 E/EFL     (  351): evas-gl_x11<351> modules/evas/engines/gl_x11/evas_engine.c:2507 _native_bind_cb() glEGLImageTargetTexture2DOES() failed.
04-05 01:35:15.012+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:35:15.012+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-05 01:35:15.012+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_pause_cb(304) > widget obj was paused
04-05 01:35:15.012+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(152) > enter background group
04-05 01:35:15.012+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: bg
04-05 01:35:15.022+0900 I/APP_CORE(21855): appcore-efl.c: __do_app(514) > [APP 21855] Event: RESUME State: CREATED
04-05 01:35:15.032+0900 I/APP_CORE(21855): appcore-efl.c: __do_app(623) > Legacy lifecycle: 0
04-05 01:35:15.032+0900 I/APP_CORE(21855): appcore-efl.c: __do_app(625) > [APP 21855] Initial Launching, call the resume_cb
04-05 01:35:15.032+0900 I/CAPI_APPFW_APPLICATION(21855): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-05 01:35:15.492+0900 W/STARTER (  709): hw_key.c: _key_release_cb(578) > [_key_release_cb:578] Home Key is released
04-05 01:35:15.492+0900 E/EFL     (  842): ecore_x<842> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=121634855
04-05 01:35:15.492+0900 E/EFL     (  858): ecore_x<858> lib/ecore_x/xlib/ecore_x_events.c:377 _ecore_key_press() Ecore KeyEvent:release time=121634855
04-05 01:35:15.492+0900 E/cluster-view(  858): homescreen-view-manager.cpp: _OnKeyEvent(1048) >  receive[XF86Home]Key [Up]Event!! 
04-05 01:35:15.502+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(355) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:355:E] dbus_connection_send error(No reply)
04-05 01:35:15.502+0900 E/STARTER (  709): lock-daemon-lite.c: _lockd_invoke_dbus_method_sync(359) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.54/src/lock-daemon-lite.c:359:E] dbus_connection_send error(org.freedesktop.DBus.Error.UnknownMethod:Method "getstatus" with signature "" on interface "org.tizen.system.deviced.hall" doesn't exist
04-05 01:35:15.502+0900 E/STARTER (  709): )
04-05 01:35:15.502+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(98) > enter syspopup term handler
04-05 01:35:15.502+0900 I/SYSPOPUP(  854): syspopup.c: __X_syspopup_term_handler(108) > term action 1 - volume
04-05 01:35:15.502+0900 E/VOLUME  (  854): volume_x_event.c: volume_x_input_event_unregister(354) > [volume_x_input_event_unregister:354] (s_info.event_outer_touch_handler == NULL) -> volume_x_input_event_unregister() return
04-05 01:35:15.502+0900 E/VOLUME  (  854): volume_control.c: volume_control_close(841) > [volume_control_close:841] Failed to unregister x input event handler
04-05 01:35:15.672+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1604
04-05 01:35:15.693+0900 I/Tizen::App( 1231): (499) > LaunchedApp(com.samsung.task-mgr)
04-05 01:35:15.693+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for com.samsung.task-mgr, 21855.
04-05 01:35:15.983+0900 E/EFL     (21855): ecore_x<21855> lib/ecore_x/xlib/ecore_x_events.c:603 _ecore_x_event_handle_button_press() ButtonEvent:press time=121635347
04-05 01:35:16.123+0900 E/EFL     (21855): ecore_x<21855> lib/ecore_x/xlib/ecore_x_events.c:756 _ecore_x_event_handle_button_release() ButtonEvent:release time=121635479
04-05 01:35:16.443+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:35:16.443+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:35:16.443+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.task-mgr(21855)
04-05 01:35:16.443+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 21855, appid: com.samsung.task-mgr, status: bg
04-05 01:35:16.443+0900 I/CAPI_APPFW_APPLICATION(21855): app_main.c: _ui_app_appcore_pause(689) > app_appcore_pause
04-05 01:35:16.443+0900 W/TASK_MGR_LITE(21855): task-mgr-lite.c: _pause_app(406) > 
04-05 01:35:16.443+0900 I/CAPI_APPFW_APPLICATION(21855): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-05 01:35:16.453+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:35:16.453+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 10498
04-05 01:35:16.453+0900 W/AUL     (21855): launch.c: app_request_to_launchpad(396) > request cmd(4) to(10498)
04-05 01:35:16.453+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 4
04-05 01:35:16.453+0900 I/APP_CORE(10498): appcore-efl.c: __do_app(514) > [APP 10498] Event: TERMINATE State: PAUSED
04-05 01:35:16.453+0900 W/AUL_AMD (  610): amd_launch.c: __reply_handler(1083) > listen fd(33) , send fd(32), pid(10498), cmd(4)
04-05 01:35:16.453+0900 W/AUL     (21855): launch.c: app_request_to_launchpad(425) > request cmd(4) result(0)
04-05 01:35:16.463+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:35:16.463+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:35:16.463+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 22
04-05 01:35:16.463+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(1201) > app status : 5
04-05 01:35:16.463+0900 E/TASK_MGR_LITE(21855): recent_app_viewer.c: destroy_recent_app_viewer(1583) > destroy_recent_app_viewer
04-05 01:35:16.493+0900 E/TASK_MGR_LITE(21855): recent_apps.c: list_destroy(376) > (NULL == list) -> list_destroy() return
04-05 01:35:16.493+0900 E/APP_CORE(21855): appcore.c: appcore_flush_memory(793) > Appcore not initialized
04-05 01:35:16.493+0900 E/TIZEN_N_EFL_UTIL_WINDOW(10498): efl_util_window_dump.c: _efl_util_capture_window_get_window_buffer(526) > 
04-05 01:35:16.493+0900 E/TIZEN_N_EFL_UTIL_WINDOW(10498):  video buffer captured successfully
04-05 01:35:16.503+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:16.503+0900 I/TIZEN_N_EFL_UTIL_WINDOW(10498): efl_util_window_dump.c: efl_util_capture_windows_in_buffer(832) > Windump Time = 47
04-05 01:35:16.503+0900 E/APP_CORE(10498): appcore-efl.c: _capture_and_make_file(1619) > win[6000003] widget[720] height[1280]
04-05 01:35:16.503+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(3)
04-05 01:35:16.503+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:35:16.503+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3349) > back key ungrab error
04-05 01:35:16.513+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(180) > send_signal FG com.samsung.homescreen(858)
04-05 01:35:16.513+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 858, appid: com.samsung.homescreen, status: fg
04-05 01:35:16.513+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 33
04-05 01:35:16.513+0900 E/APP_CORE(10498): appcore-efl.c: _capture_and_make_file(1622) > cannot a capture file for the package of [com.samsung.camera-app-lite]
04-05 01:35:16.513+0900 I/CAPI_APPFW_APPLICATION(10498): app_main.c: _ui_app_appcore_terminate(663) > app_appcore_terminate
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamApp.cpp: onTerminate(186) > [0;35mBEGIN[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: operator()(125) > [0;35mevent type: 3[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: __terminate(1365) > [0;35mBEGIN[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: destroyShot(390) > [0;35mBEGIN[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: destroyShot(399) > [0;35mEND[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: destroyRecord(444) > [0;35mBEGIN[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: destroyRecord(451) > [0;35mEND[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: __terminate(1386) > [0;35mEND[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamStandbyView.cpp: operator()(267) > [0;35mevent type: 3[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamControl.cpp: unsetFaceDetectedCallback(844) > [0;35munset face detected callback: 1[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamView.cpp: stopSelfTerminateTimer(356) > [0;35mHIT[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: setMdnieMode(439) > [0;35mBEGIN[0;m
04-05 01:35:16.513+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(714) > [0;35mBEGIN[0;m
04-05 01:35:16.523+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(756) > [0;35mEND[0;m
04-05 01:35:16.523+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: __setEnhanceScenario(476) > [0;35mset mdnie - SCENARIO_UI [0;m
04-05 01:35:16.523+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(714) > [0;35mBEGIN[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: __invokeDbusMethodSync(756) > [0;35mEND[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: setMdnieMode(443) > [0;35mEND[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamLauncher.cpp: terminatePreloadImageViewer(242) > [0;35mBEGIN[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamLauncher.cpp: terminatePreloadImageViewer(268) > [0;35mEND[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamThreadMgr.cpp: joinThread(85) > [0;35mBEGIN[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamFileRegisterMgr.cpp: __registerFileThreadCb(325) > [0;35mEnd of REGISTER_FILE thread loop[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamFileRegisterMgr.cpp: __registerFileThreadCb(330) > [0;35mEND[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamThreadMgr.cpp: joinThread(102) > [0;35mEND[0;m
04-05 01:35:16.533+0900 I/CAPI_CONTENT_MEDIA_CONTENT(10498): media_content.c: media_content_disconnect(940) > [32m[10498]ref count changed to: 0
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamSubControlMgr.cpp: __threadCb(355) > [0;35mEnd of thread loop[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamSubControlMgr.cpp: __threadCb(360) > [0;35mEND[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamThreadMgr.cpp: joinThread(85) > [0;35mBEGIN[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamThreadMgr.cpp: joinThread(102) > [0;35mEND[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamCoordRotationMgr.cpp: stop(83) > [0;35mBEGIN[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamCoordRotationMgr.cpp: stop(86) > [0;35malready stopped. skip this[0;m
04-05 01:35:16.533+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: unlockDisplay(97) > [0;35mBEGIN[0;m
04-05 01:35:16.543+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: unlockDisplay(112) > [0;35mEND[0;m
04-05 01:35:16.543+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: unregisterEvent(416) > [0;35mBEGIN[0;m
04-05 01:35:16.553+0900 W/AUL_AMD (  610): amd_launch.c: __e17_status_handler(3328) > pid(858) status(0)
04-05 01:35:16.553+0900 I/MALI    (21855): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=21855   close drm_fd=30 
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamSystemDeviceMgr.cpp: unregisterEvent(434) > [0;35mEND[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamAFMgr.cpp: stop(130) > [0;35mBEGIN[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamAFMgr.cpp: reset(152) > [0;35mHIT[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamDevControl.cpp: stopAutoFocusing(557) > [0;35mBEGIN[0;m
04-05 01:35:16.563+0900 E/TIZEN_N_CAMERA(10498): camera.c: __convert_camera_error_code(231) > [camera_cancel_focusing] INVALID_STATE(0xfe6f0002) : core frameworks error code(0x80000817)
04-05 01:35:16.563+0900 E/CAM_APP (10498): CamDevControl.cpp: stopAutoFocusing(562) > [0;31m* Critical * camera_cancel_focusing failed - [-26279934][0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamAFMgr.cpp: stop(146) > [0;35mEND[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamControl.cpp: destroyShot(390) > [0;35mBEGIN[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamControl.cpp: destroyShot(399) > [0;35mEND[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamControl.cpp: destroyRecord(444) > [0;35mBEGIN[0;m
04-05 01:35:16.563+0900 W/CAM_APP (10498): CamControl.cpp: destroyRecord(451) > [0;35mEND[0;m
04-05 01:35:16.573+0900 I/UXT     (29479): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-05 01:35:16.573+0900 E/efl-extension(10498): efl_extension.c: eext_win_keygrab_unset(123) >   Can't unset keygrab of [XF86AudioRaiseVolume].
04-05 01:35:16.573+0900 E/efl-extension(10498): efl_extension.c: eext_win_keygrab_unset(123) >   Can't unset keygrab of [XF86AudioLowerVolume].
04-05 01:35:16.573+0900 W/CAM_APP (10498): CamDevControl.cpp: destroyDevice(130) > [0;35mBEGIN[0;m
04-05 01:35:16.573+0900 W/CAM_APP (10498): CamSoundSessionMgr.cpp: destroySession(67) > [0;35mBEGIN[0;m
04-05 01:35:16.573+0900 I/TIZEN_N_SOUND_MANAGER(10498): sound_manager_product.c: sound_manager_multi_session_destroy(939) > >> enter : session=0xb8bc9f38
04-05 01:35:16.573+0900 I/TIZEN_N_SOUND_MANAGER(10498): sound_manager_product.c: sound_manager_multi_session_destroy(1001) > << leave : already set same option(0), skip it
04-05 01:35:16.573+0900 I/TIZEN_N_SOUND_MANAGER(10498): sound_manager_product.c: sound_manager_multi_session_destroy(1010) > << leave : session=(nil)
04-05 01:35:16.573+0900 W/CAM_APP (10498): CamSoundSessionMgr.cpp: destroySession(75) > [0;35mEND[0;m
04-05 01:35:16.573+0900 E/TIZEN_N_RECORDER(10498): recorder.c: __convert_recorder_error_code(189) > [recorder_destroy] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:35:16.573+0900 W/TIZEN_N_CAMERA(10498): camera.c: camera_destroy(984) > camera handle 0xb8bca688
04-05 01:35:16.583+0900 I/TIZEN_N_CAMERA(10498): camera.c: _camera_remove_cb_message(91) > start
04-05 01:35:16.583+0900 W/TIZEN_N_CAMERA(10498): camera.c: _camera_remove_cb_message(117) > There is no remained callback
04-05 01:35:16.583+0900 I/TIZEN_N_CAMERA(10498): camera.c: _camera_remove_cb_message(122) > done
04-05 01:35:16.583+0900 W/CAM_APP (10498): CamDevControl.cpp: destroyDevice(152) > [0;35mEND[0;m
04-05 01:35:16.583+0900 W/CAM_APP (10498): CamApp.cpp: onTerminate(239) > [0;35mEND[0;m
04-05 01:35:16.593+0900 W/CAM_APP (10498): CamGuideText.cpp: clear(79) > [0;35mguide text is not displayed again until CamGuideText is re-created[0;m
04-05 01:35:16.603+0900 I/APP_CORE(  858): appcore-efl.c: __do_app(514) > [APP 858] Event: RESUME State: PAUSED
04-05 01:35:16.603+0900 I/CAPI_APPFW_APPLICATION(  858): app_main.c: _ui_app_appcore_resume(706) > app_appcore_resume
04-05 01:35:16.603+0900 E/cluster-home(  858): homescreen.cpp: OnResume(233) >  app resume
04-05 01:35:16.603+0900 W/CAM_APP (10498): CamButton.cpp: ~CamButton(45) > [0;35mname = [Camera button], buttonMenu = [0][0;m
04-05 01:35:16.613+0900 W/CAM_APP (10498): CamButton.cpp: ~CamButton(45) > [0;35mname = [Camcorder button], buttonMenu = [2][0;m
04-05 01:35:16.613+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:16.613+0900 W/CAM_APP (10498): CamButton.cpp: ~CamButton(45) > [0;35mname = [Switch button], buttonMenu = [37][0;m
04-05 01:35:16.613+0900 W/CAM_APP (10498): CamButton.cpp: ~CamButton(45) > [0;35mname = [Quick setting button], buttonMenu = [7][0;m
04-05 01:35:16.623+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(557) > [0;40;31mResumeWidgetInstance[0;m
04-05 01:35:16.623+0900 W/CAM_APP (10498): CamButton.cpp: ~CamButton(45) > [0;35mname = [Thumbnail button], buttonMenu = [8][0;m
04-05 01:35:16.623+0900 W/CAM_APP (10498): CamButton.cpp: ~CamButton(45) > [0;35mname = [Mode button], buttonMenu = [55][0;m
04-05 01:35:16.633+0900 E/EFL     (10498): <10498> elm_main.c:1305 elm_object_part_content_unset() safety check failed: obj == NULL
04-05 01:35:16.643+0900 E/weather-widget( 1448): WidgetView.cpp: Resume(456) > [0;40;31mNo need to Update[0;m
04-05 01:35:16.643+0900 I/Tizen::System( 1231): (259) > Active app [com.samsun], current [com.samsun] 
04-05 01:35:16.643+0900 I/Tizen::System( 1231): (273) > Current App[com.samsun] is already actived.
04-05 01:35:16.673+0900 E/weather-common( 1448): CityDBController.cpp: GetPageIndexOfCurrentCity(567) > [0;40;31mNo result : 101[0;m
04-05 01:35:16.693+0900 I/MALI    (10498): egl_platform_x11.c: __egl_platform_terminate(358) > [EGL-X11] PID=10498   close drm_fd=30 
04-05 01:35:16.704+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_create(409) > New handle created[0xb7a966e8]
04-05 01:35:16.704+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_get_type(463) > Connected Network = 2
04-05 01:35:16.704+0900 I/CAPI_NETWORK_CONNECTION( 1448): connection.c: connection_destroy(427) > Destroy handle: 0xb7a966e8
04-05 01:35:16.704+0900 E/weather-common( 1448): Network.cpp: IsNetworkAvailable(161) > [0;40;31mnetwork isAvailable:1[0;m
04-05 01:35:16.704+0900 E/weather-widget( 1448): WidgetMain.cpp: ResumeWidgetInstance(646) > [0;40;31mwe don't need to refresh[0;m
04-05 01:35:16.704+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __provider_resume_cb(322) > widget obj was resumed
04-05 01:35:16.704+0900 I/CAPI_WIDGET_APPLICATION( 1448): widget_app.c: __check_status_for_cgroup(142) > enter foreground group
04-05 01:35:16.704+0900 W/AUL     ( 1448): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 1448, appid: com.samsung.weather-m-widget, status: fg
04-05 01:35:16.714+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:35:16.734+0900 E/TBM     (29479): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:35:16.734+0900 I/MALI    (29479): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=29479   open drm_fd=30 
04-05 01:35:16.924+0900 W/CAM_APP (10498): main.cpp: main(32) > [0;35mEND[0;m
04-05 01:35:16.964+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:16.964+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:16.964+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:16.964+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:16.964+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:16.964+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:16.994+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 10498 pgid = 10498
04-05 01:35:16.994+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(10498)
04-05 01:35:17.034+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-05 01:35:17.034+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(143) > dead_pid(21855)
04-05 01:35:17.034+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 10498
04-05 01:35:17.034+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 10498
04-05 01:35:17.034+0900 I/Tizen::App( 1231): (243) > App[com.samsung.camera-app-lite] pid[10498] terminate event is forwarded
04-05 01:35:17.034+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-05 01:35:17.034+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.camera-app-lite, 10498, ]
04-05 01:35:17.034+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-05 01:35:17.034+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.camera-app-lite)
04-05 01:35:17.034+0900 I/Tizen::App( 1231): (512) > Not registered pid(10498)
04-05 01:35:17.034+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.camera-app-lite]
04-05 01:35:17.044+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:35:17.044+0900 W/CAM_SERVICE( 1583): CamService.cpp: __launchCameraApp(86) > [33mBEGIN[0m
04-05 01:35:17.044+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:35:17.044+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1607
04-05 01:35:17.054+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-05 01:35:17.054+0900 W/AUL     ( 1583): launch.c: app_request_to_launchpad(396) > request cmd(0) to(com.samsung.camera-app-lite)
04-05 01:35:17.054+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-05 01:35:17.054+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:35:17.054+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.camera-app-lite, 10498.
04-05 01:35:17.054+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 1583
04-05 01:35:17.054+0900 I/AUL_AMD (  610): amd_launch.c: __check_app_control_privilege(1830) > Skip the privilege check in case of preloaded apps
04-05 01:35:17.074+0900 I/AUL_PAD ( 1673): sigchild.h: __sigchild_action(149) > __send_app_dead_signal(0)
04-05 01:35:17.074+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-05 01:35:17.074+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(162) > dead_pid = 21855 pgid = -1
04-05 01:35:17.074+0900 I/AUL_PAD ( 1673): sigchild.h: __launchpad_process_sigchld(170) > after __sigchild_action
04-05 01:35:17.074+0900 E/AUL_PAD ( 1673): launchpad.c: main(698) > error reading sigchld info
04-05 01:35:17.074+0900 I/ESD     (  893): esd_main.c: __esd_app_dead_handler(1773) > pid: 21855
04-05 01:35:17.074+0900 I/Tizen::App( 1231): (243) > App[com.samsung.task-mgr] pid[21855] terminate event is forwarded
04-05 01:35:17.074+0900 I/Tizen::System( 1231): (256) > osp.accessorymanager.service provider is found.
04-05 01:35:17.074+0900 I/Tizen::System( 1231): (196) > Accessory Owner is removed [com.samsung.task-mgr, 21855, ]
04-05 01:35:17.074+0900 I/Tizen::System( 1231): (256) > osp.system.service provider is found.
04-05 01:35:17.074+0900 I/Tizen::App( 1231): (506) > TerminatedApp(com.samsung.task-mgr)
04-05 01:35:17.074+0900 I/Tizen::App( 1231): (512) > Not registered pid(21855)
04-05 01:35:17.074+0900 I/Tizen::System( 1231): (246) > Terminated app [com.samsung.task-mgr]
04-05 01:35:17.074+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:35:17.084+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1608
04-05 01:35:17.084+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-05 01:35:17.084+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-05 01:35:17.094+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-05 01:35:17.094+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-05 01:35:17.094+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:35:17.094+0900 I/Tizen::App( 1231): (782) > Finished invoking application event listener for com.samsung.task-mgr, 21855.
04-05 01:35:17.194+0900 W/CAM_APP (29479): main.cpp: main(26) > [0;35mBEGIN[0;m
04-05 01:35:17.194+0900 I/CAPI_APPFW_APPLICATION(29479): app_main.c: ui_app_main(789) > app_efl_main
04-05 01:35:17.194+0900 I/CAPI_APPFW_APPLICATION(29479): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-05 01:35:17.194+0900 W/CAM_APP (29479): CamApp.cpp: onCreate(102) > [0;35mBEGIN[0;m
04-05 01:35:17.264+0900 I/CAPI_CONTENT_MEDIA_CONTENT(29479): media_content.c: media_content_connect(856) > [32m[29479]ref count : 0
04-05 01:35:17.264+0900 I/CAPI_CONTENT_MEDIA_CONTENT(29479): media_content.c: media_content_connect(888) > [32m[29479]ref count changed to: 1
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamThreadMgr.cpp: createThread(47) > [0;35mBEGIN[0;m
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamThreadMgr.cpp: createThread(67) > [0;35mEND[0;m
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamFileRegisterMgr.cpp: __registerFileThreadCb(277) > [0;35mBEGIN[0;m
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamDreamTemplateInfo.cpp: init(47) > [0;35mSTART[0;m
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamDreamTemplateInfo.cpp: init(65) > [0;35mg_key_file_load_from_file failed: No such file or directory[0;m
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamDreamTemplateInfo.cpp: init(76) > [0;35mload default data for dreamshot[0;m
04-05 01:35:17.264+0900 W/CAM_APP (29479): CamDreamTemplateInfo.cpp: init(90) > [0;35mEND[0;m
04-05 01:35:17.294+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 29479, appid: com.samsung.camera-app-lite
04-05 01:35:17.294+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-05 01:35:17.294+0900 W/AUL     ( 1583): launch.c: app_request_to_launchpad(425) > request cmd(0) result(29479)
04-05 01:35:17.294+0900 W/CAM_SERVICE( 1583): CamService.cpp: __launchCameraApp(119) > [33mEND[0m
04-05 01:35:17.294+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(327) > __app_dead_handler, pid: 21855
04-05 01:35:17.294+0900 W/AUL_AMD (  610): amd_main.c: __app_dead_handler(333) > app_group_leader_app, pid: 21855
04-05 01:35:17.304+0900 W/CAM_APP (29479): CamSiopControlMgr.cpp: start(49) > [0;35mBEGIN[0;m
04-05 01:35:17.304+0900 W/CAM_APP (29479): CamSiopControlMgr.cpp: start(62) > [0;35mEND[0;m
04-05 01:35:17.304+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:35:17.304+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: 29479
04-05 01:35:17.304+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 12
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamApp.cpp: onCreate(180) > [0;35mEND[0;m
04-05 01:35:17.314+0900 I/APP_CORE(29479): appcore-efl.c: __do_app(514) > [APP 29479] Event: RESET State: CREATED
04-05 01:35:17.314+0900 I/CAPI_APPFW_APPLICATION(29479): app_main.c: _ui_app_appcore_reset(723) > app_appcore_reset
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamApp.cpp: onAppControl(244) > [0;35mBEGIN : firstLaunch - [1][0;m
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamRequestParser.cpp: parse(61) > [0;35mBEGIN[0;m
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamRequestParser.cpp: __parseMainData(127) > [0;35moperation - [http://tizen.org/appcontrol/operation/prelaunch][0;m
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamRequestParser.cpp: parse(76) > [0;35mdonot need to parse other data[0;m
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamRequestParser.cpp: parse(83) > [0;35mEND[0;m
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamDevControl.cpp: createDevice(91) > [0;35mBEGIN - type : [0][0;m
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamSoundSessionMgr.cpp: createSession(54) > [0;35mBEGIN[0;m
04-05 01:35:17.314+0900 I/TIZEN_N_SOUND_MANAGER(29479): sound_manager_product.c: sound_manager_multi_session_create(656) > >> enter : type=2, session=0xb7b9f0f8
04-05 01:35:17.314+0900 I/TIZEN_N_SOUND_MANAGER(29479): sound_manager_product.c: sound_manager_multi_session_create(726) > << leave : type=2, session=0xb7b9f0f8
04-05 01:35:17.314+0900 W/CAM_APP (29479): CamSoundSessionMgr.cpp: createSession(60) > [0;35mEND[0;m
04-05 01:35:17.314+0900 W/TIZEN_N_CAMERA(29479): camera.c: camera_create(879) > device name = [0]
04-05 01:35:17.374+0900 W/TIZEN_N_CAMERA(29479): camera.c: camera_create(963) > camera handle 0xb7b9f868
04-05 01:35:17.374+0900 W/TIZEN_N_RECORDER(29479): recorder.c: recorder_create_videorecorder(553) > permission check done
04-05 01:35:17.374+0900 E/TIZEN_N_RECORDER(29479): recorder.c: __convert_recorder_error_code(189) > [audio-device] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:35:17.374+0900 E/TIZEN_N_RECORDER(29479): recorder.c: __convert_recorder_error_code(189) > [recorder_attr_set_audio_tuning] ERROR_NONE(0x00000000) : core frameworks error code(0x00000000)
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamDevControl.cpp: createDevice(124) > [0;35mEND[0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamSubControlMgr.cpp: runSubControlThread(90) > [0;35mBEGIN - controlType:[9][0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamSubControlMgr.cpp: runSubControlThread(101) > [0;35mcreate CONTROL_CAMERA thread[0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamThreadMgr.cpp: createThread(47) > [0;35mBEGIN[0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamThreadMgr.cpp: createThread(67) > [0;35mEND[0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamSubControlMgr.cpp: __threadCb(131) > [0;35mBEGIN[0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamSubControlMgr.cpp: __threadCb(152) > [0;35mstart thread control type - [9][0;m
04-05 01:35:17.374+0900 W/CAM_APP (29479): CamSubControlMgr.cpp: runSubControlThread(125) > [0;35mEND[0;m
04-05 01:35:17.374+0900 I/TIZEN_N_CAMERA(29479): camera_product.c: camera_preload_framework(1142) > start load plugin
04-05 01:35:17.384+0900 W/CAM_APP (29479): CamView.cpp: __initialize(67) > [0;35mBEGIN[0;m
04-05 01:35:17.384+0900 W/CAM_APP (29479): CamView.cpp: __initialize(85) > [0;35mEND[0;m
04-05 01:35:17.434+0900 W/CAM_APP (29479): CamApp.cpp: onAppControl(378) > [0;35mset _E_MOVE_PANEL_SCROLLABLE_STATE as unblocked[0;m
04-05 01:35:17.434+0900 W/CAM_APP (29479): CamSystemDeviceMgr.cpp: isIdleLocked(353) > [0;35mVCONFKEY_IDLE_LOCK_STATE state = [0][0;m
04-05 01:35:17.444+0900 W/CAM_APP (29479): CamApp.cpp: onAppControl(396) > [0;35mEND[0;m
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.444+0900 E/EFL     (29479): edje<29479> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:17.444+0900 E/EFL     (29479): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:17.554+0900 I/TIZEN_N_CAMERA(29479): camera_product.c: camera_preload_framework(1152) > done load plugin
04-05 01:35:17.554+0900 W/CAM_APP (29479): CamSubControlMgr.cpp: __threadCb(351) > [0;35mdone[0;m
04-05 01:35:18.295+0900 W/AUL_AMD (  610): amd_key.c: _key_ungrab(269) > fail(-1) to ungrab key(XF86Back)
04-05 01:35:18.295+0900 W/AUL_AMD (  610): amd_launch.c: __grab_timeout_handler(1623) > back key ungrab error
04-05 01:35:18.325+0900 E/RESOURCED(  664): resourced-dbus.c: resourced_dbus_system_hash_drop_busname(324) > Does not exist in busname hash: :1.1610
04-05 01:35:18.325+0900 I/Tizen::App( 1231): (499) > LaunchedApp(com.samsung.camera-app-lite)
04-05 01:35:18.325+0900 I/Tizen::App( 1231): (733) > Finished invoking application event listener for com.samsung.camera-app-lite, 29479.
04-05 01:35:19.036+0900 I/UXT     (29493): Uxt_ObjectManager.cpp: OnInitialized(737) > Initialized.
04-05 01:35:19.076+0900 E/TBM     (29493): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:35:19.076+0900 I/MALI    (29493): egl_platform_x11.c: __egl_platform_initialize(242) > [EGL-X11] PID=29493   open drm_fd=30 
04-05 01:35:19.186+0900 E/EFL     (29493): edje<29493> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:19.186+0900 E/EFL     (29493): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:19.186+0900 E/EFL     (29493): edje<29493> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:19.186+0900 E/EFL     (29493): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:19.186+0900 E/EFL     (29493): edje<29493> lib/edje/edje_embryo.c:4134 _edje_embryo_test_run() You are running Embryo->EDC->Embryo with script program '_p26';
04-05 01:35:19.186+0900 E/EFL     (29493): By the power of Grayskull, your previous Embryo stack is now broken!
04-05 01:35:21.438+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:35:21.458+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:35:21.458+0900 W/AUL_AMD (  610): amd_status.c: __app_terminate_timer_cb(421) > send SIGKILL: No such process
04-05 01:35:22.299+0900 W/AUL     (  610): amd_app_group.c: __set_fg_flag(190) > send_signal BG com.samsung.camera-app-lite(29479)
04-05 01:35:22.299+0900 W/AUL     (  610): app_signal.c: aul_send_app_status_change_signal(581) > send_app_status_change_signal, pid: 29479, appid: com.samsung.camera-app-lite, status: bg
04-05 01:35:24.701+0900 E/PKGMGR_SERVER(29531): pkgmgr-server.c: main(2414) > package manager server start
04-05 01:35:24.751+0900 E/PKGMGR  (29529): pkgmgr.c: __check_sync_process(883) > file is can not remove[/tmp/org.example.client, -1]
04-05 01:35:24.791+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 14
04-05 01:35:24.801+0900 W/AUL_AMD (  610): amd_request.c: __send_result_to_client(158) > __send_result_to_client, pid: -1
04-05 01:35:24.811+0900 E/PKGMGR_SERVER(29531): pkgmgr-server.c: sighandler(417) > child NORMAL exit [29534]
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_remove(378) > (!icon) -> list_try_to_find_icon_to_remove() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.592+0900 E/INDICATOR(  661): list.c: list_try_to_find_icon_to_show(299) > (!icon) -> list_try_to_find_icon_to_show() return
04-05 01:35:25.602+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:25.602+0900 E/INDICATOR(  661): box.c: _update_icon(232) > (!list) -> _update_icon() return
04-05 01:35:26.643+0900 E/PKGMGR_SERVER(29531): pkgmgr-server.c: exit_server(1381) > exit_server Start [backend_status=1, queue_status=1, drm_status=1] 
04-05 01:35:26.643+0900 E/PKGMGR_SERVER(29531): pkgmgr-server.c: main(2471) > package manager server terminated.
04-05 01:35:27.024+0900 W/AUL     (29584): launch.c: app_request_to_launchpad(396) > request cmd(0) to(org.example.client)
04-05 01:35:27.024+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 0
04-05 01:35:27.034+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /usr/bin/launch_app, ret : 0
04-05 01:35:27.044+0900 I/AUL     (  610): menu_db_util.h: _get_app_info_from_db_by_apppath(242) > path : /bin/bash, ret : 0
04-05 01:35:27.044+0900 E/AUL_AMD (  610): amd_launch.c: _start_app(2499) > no caller appid info, ret: -1
04-05 01:35:27.044+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(2508) > caller pid : 29584
04-05 01:35:27.044+0900 E/AUL_AMD (  610): amd_appinfo.c: appinfo_get_value(1296) > appinfo get value: Invalid argument, 19
04-05 01:35:27.054+0900 E/RESOURCED(  664): block.c: block_prelaunch_state(134) > insert data org.example.client, table num : 5
04-05 01:35:27.054+0900 E/RESOURCED(  664): heart-memory.c: heart_memory_get_data(601) > hashtable heart_memory_app_list is NULL
04-05 01:35:27.054+0900 W/AUL_AMD (  610): amd_launch.c: _start_app(3052) > pad pid(-5)
04-05 01:35:27.054+0900 W/AUL_PAD ( 1673): launchpad.c: __launchpad_main_loop(520) > Launch on type-based process-pool
04-05 01:35:27.054+0900 W/AUL_PAD ( 1673): launchpad.c: __send_result_to_caller(267) > Check app launching
04-05 01:35:27.064+0900 I/abc     (29434): abc
04-05 01:35:27.064+0900 I/CAPI_APPFW_APPLICATION(29434): app_main.c: ui_app_main(789) > app_efl_main
04-05 01:35:27.074+0900 I/CAPI_APPFW_APPLICATION(29434): app_main.c: _ui_app_appcore_create(641) > app_appcore_create
04-05 01:35:27.094+0900 E/TBM     (29434): tbm_bufmgr.c: _tbm_bufmgr_init_state(691) > USE TGL LOCK!
04-05 01:35:27.154+0900 W/AUL     (  610): app_signal.c: aul_send_app_launch_request_signal(423) > send_app_launch_signal, pid: 29434, appid: org.example.client
04-05 01:35:27.154+0900 E/AUL     (  610): amd_app_group.c: app_group_start_app(1037) > app_group_start_app
04-05 01:35:27.164+0900 W/AUL     (29584): launch.c: app_request_to_launchpad(425) > request cmd(0) result(29434)
04-05 01:35:27.334+0900 D/basicui (29434): successed to load edc file
04-05 01:35:27.374+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:27.374+0900 E/EFL     (  351): eo<351> lib/eo/eo.c:676 _eo_call_resolve() in lib/edje/edje_object.eo.c:316: func 'edje_obj_signal_emit' (415) could not be resolved for class 'Evas_Object_Smart'.
04-05 01:35:27.394+0900 I/Tizen::System( 1231): (259) > Active app [org.exampl], current [com.samsun] 
04-05 01:35:27.394+0900 I/Tizen::Io( 1231): (729) > Entry not found
04-05 01:35:27.394+0900 I/Tizen::System( 1231): (157) > change brightness system value.
04-05 01:35:27.404+0900 W/AUL_AMD (  610): amd_request.c: __request_handler(906) > __request_handler: 15
04-05 01:35:27.674+0900 W/CRASH_MANAGER(29422): worker.c: worker_job(1199) > 1129434636c69149132372
